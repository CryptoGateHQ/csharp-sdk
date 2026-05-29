using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using CryptoGate.Exceptions;
using CryptoGate.Models;

namespace CryptoGate;

public class CryptoGateClient : IDisposable
{
    private const string DefaultBaseUrl = "https://api.cryptogate.live";
    private const string SdkVersion     = "1.0.0";

    private readonly HttpClient _http;
    private readonly string     _baseUrl;

    public CryptoGateClient(string apiKey, string? baseUrl = null, int timeoutSeconds = 30)
    {
        if (string.IsNullOrEmpty(apiKey))
            throw new ArgumentException("A valid API key is required", nameof(apiKey));

        _baseUrl = (baseUrl ?? DefaultBaseUrl).TrimEnd('/');
        _http    = new HttpClient { Timeout = TimeSpan.FromSeconds(timeoutSeconds) };
        _http.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", apiKey);
        _http.DefaultRequestHeaders.Add("User-Agent", $"cryptogate-csharp-sdk/{SdkVersion}");
        _http.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
    }

    // ── Transactions ──────────────────────────────────────────────────────────

    /// <param name="currency">Fiat currency. Supported: USD (default), PLN, EUR, GBP.</param>
    /// <param name="metadata">Free-form key/value pairs returned in every webhook. Max 20 keys, string values, 4 KB.</param>
    /// <param name="customerEmail">Pre-fill email on the hosted payment page.</param>
    /// <param name="successUrl">Redirect URL after confirmed payment.</param>
    /// <param name="cancelUrl">Redirect URL after expiry/cancellation.</param>
    public Task<Transaction> CreateTransactionAsync(
        string crypto, decimal amount, string currency = "USD",
        Dictionary<string, string>? metadata = null,
        string? customerEmail = null, string? successUrl = null, string? cancelUrl = null,
        CancellationToken ct = default)
    {
        if (string.IsNullOrEmpty(crypto)) throw new ValidationException("crypto is required");
        if (amount == 0)                  throw new ValidationException("amount is required");

        return PostAsync<Transaction>("/transactions/create", new {
            crypto, amount, currency,
            metadata,
            customer_email = customerEmail,
            success_url    = successUrl,
            cancel_url     = cancelUrl,
        }, ct);
    }

    /// <summary>Create a detailed transaction with line items (Pro/Enterprise plans only).</summary>
    /// <param name="orderId">Required. Your internal order ID, returned in every webhook.</param>
    public Task<Transaction> CreateDetailedTransactionAsync(
        string crypto, string orderId, IEnumerable<LineItem> items,
        string currency = "USD",
        Dictionary<string, string>? metadata = null,
        string? customerEmail = null, string? successUrl = null, string? cancelUrl = null,
        CancellationToken ct = default)
    {
        if (string.IsNullOrEmpty(crypto))  throw new ValidationException("crypto is required");
        if (string.IsNullOrEmpty(orderId)) throw new ValidationException("orderId is required");

        return PostAsync<Transaction>("/transactions/create-detailed", new {
            crypto, order_id = orderId, items, currency,
            metadata,
            customer_email = customerEmail,
            success_url    = successUrl,
            cancel_url     = cancelUrl,
        }, ct);
    }

    public Task<Transaction> GetTransactionAsync(string txid, CancellationToken ct = default)
    {
        if (string.IsNullOrEmpty(txid)) throw new ValidationException("txid is required");
        return GetAsync<Transaction>($"/transactions/{Uri.EscapeDataString(txid)}", ct);
    }

    public Task<ListResult> ListTransactionsAsync(int page = 1, int limit = 20,
        CancellationToken ct = default)
        => GetAsync<ListResult>($"/transactions/list?page={page}&limit={limit}", ct);

    public Task<Transaction> CancelTransactionAsync(string txid, CancellationToken ct = default)
    {
        if (string.IsNullOrEmpty(txid)) throw new ValidationException("txid is required");
        return PostAsync<Transaction>($"/transactions/{Uri.EscapeDataString(txid)}/cancel", null, ct);
    }

    // ── Cryptos & Prices ──────────────────────────────────────────────────────

    public Task<CryptosResult> GetSupportedCryptosAsync(CancellationToken ct = default)
        => GetAsync<CryptosResult>("/cryptos/list", ct);

    public Task<RatesResult> GetExchangeRatesAsync(CancellationToken ct = default)
        => GetAsync<RatesResult>("/prices", ct);

    // ── HTTP ──────────────────────────────────────────────────────────────────

    private async Task<T> GetAsync<T>(string path, CancellationToken ct)
    {
        var resp = await _http.GetAsync(_baseUrl + path, ct);
        return await HandleResponseAsync<T>(resp);
    }

    private async Task<T> PostAsync<T>(string path, object? body, CancellationToken ct)
    {
        var content = body is not null
            ? new StringContent(JsonSerializer.Serialize(body), Encoding.UTF8, "application/json")
            : null;
        var resp = await _http.PostAsync(_baseUrl + path, content, ct);
        return await HandleResponseAsync<T>(resp);
    }

    private static async Task<T> HandleResponseAsync<T>(HttpResponseMessage resp)
    {
        var json = await resp.Content.ReadAsStringAsync();
        if (resp.IsSuccessStatusCode)
            return JsonSerializer.Deserialize<T>(json)!;

        using var doc = JsonDocument.Parse(json);
        var root    = doc.RootElement;
        var message = root.TryGetProperty("error",   out var e) ? e.GetString()
                    : root.TryGetProperty("message", out var m) ? m.GetString()
                    : "Unknown error";
        var code    = root.TryGetProperty("code", out var c) ? c.GetString() : null;

        throw (int)resp.StatusCode switch
        {
            401 => new AuthenticationException(message),
            404 => new NotFoundException(message),
            400 => new ValidationException(message, code ?? "VALIDATION_ERROR"),
            429 => new RateLimitException(message),
            _   => new CryptoGateException(message ?? "Unknown error",
                                           code ?? "UNKNOWN_ERROR",
                                           (int)resp.StatusCode),
        };
    }

    public void Dispose() => _http.Dispose();
}
