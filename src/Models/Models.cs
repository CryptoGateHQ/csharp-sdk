using System.Text.Json.Serialization;

namespace CryptoGate.Models;

public record Payment(
    [property: JsonPropertyName("crypto")]                  string Crypto,
    [property: JsonPropertyName("amount_usd")]              decimal AmountUsd,
    [property: JsonPropertyName("amount_crypto")]           string AmountCrypto,
    [property: JsonPropertyName("locked_rate")]             decimal LockedRate,
    [property: JsonPropertyName("address")]                 string Address,
    [property: JsonPropertyName("confirmations")]           int Confirmations,
    [property: JsonPropertyName("confirmations_required")]  int ConfirmationsRequired,
    [property: JsonPropertyName("status")]                  string Status
);

public record Transaction(
    [property: JsonPropertyName("txid")]              string Txid,
    [property: JsonPropertyName("status")]            string Status,
    [property: JsonPropertyName("amount_fiat")]       decimal AmountFiat,
    [property: JsonPropertyName("amount_usd")]        decimal AmountUsd,
    [property: JsonPropertyName("fiat_to_usd_rate")]  decimal FiatToUsdRate,
    [property: JsonPropertyName("amount_paid")]       decimal AmountPaid,
    [property: JsonPropertyName("amount_remaining")]  decimal AmountRemaining,
    [property: JsonPropertyName("currency")]          string Currency,
    [property: JsonPropertyName("payment")]           Payment Payment,
    [property: JsonPropertyName("payment_url")]       string PaymentUrl,
    [property: JsonPropertyName("expires_at")]        string ExpiresAt,
    [property: JsonPropertyName("created_at")]        string CreatedAt
);

public record Pagination(
    [property: JsonPropertyName("page")]         int Page,
    [property: JsonPropertyName("limit")]        int Limit,
    [property: JsonPropertyName("total")]        int Total,
    [property: JsonPropertyName("total_pages")]  int TotalPages
);

public record ListResult(
    [property: JsonPropertyName("transactions")]  List<Transaction> Transactions,
    [property: JsonPropertyName("pagination")]    Pagination Pagination
);

public record Crypto(
    [property: JsonPropertyName("symbol")]      string Symbol,
    [property: JsonPropertyName("name")]        string Name,
    [property: JsonPropertyName("blockchain")]  string Blockchain,
    [property: JsonPropertyName("network")]     string Network,
    [property: JsonPropertyName("type")]        string Type
);

public record CryptosResult(
    [property: JsonPropertyName("cryptocurrencies")]  List<Crypto> Cryptocurrencies,
    [property: JsonPropertyName("total")]             int Total
);

public record RatesResult(
    [property: JsonPropertyName("crypto")]      Dictionary<string, decimal> Crypto,
    [property: JsonPropertyName("fiat")]        Dictionary<string, decimal> Fiat,
    [property: JsonPropertyName("fetched_at")]  string FetchedAt
);
