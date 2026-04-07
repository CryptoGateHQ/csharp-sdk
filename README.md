# CryptoGate.SDK

Official .NET SDK for the [CryptoGate](https://cryptogate.live) payment API.

## Installation

```bash
dotnet add package CryptoGate.SDK
```

## Quick Start

```csharp
using CryptoGate;

var cg = new CryptoGateClient("sk_live_your_api_key");

var tx = await cg.CreateTransactionAsync("BTC", 50.00m);
Console.WriteLine(tx.Txid);        // MTX-A1B2C3D4
Console.WriteLine(tx.PaymentUrl);  // Redirect your customer here
```

## API Reference

```csharp
var tx     = await cg.CreateTransactionAsync("BTC", 25.00m);
var tx     = await cg.GetTransactionAsync("MTX-A1B2C3D4");
var result = await cg.ListTransactionsAsync(page: 1, limit: 20);
var tx     = await cg.CancelTransactionAsync("MTX-A1B2C3D4");

var cryptos = await cg.GetSupportedCryptosAsync();
var rates   = await cg.GetExchangeRatesAsync();
```

## Webhook Verification

```csharp
// ASP.NET Core minimal API example
app.MapPost("/webhook", async (HttpRequest request) =>
{
    using var ms = new MemoryStream();
    await request.Body.CopyToAsync(ms);
    var rawBody   = ms.ToArray();
    var signature = request.Headers["X-CryptoGate-Signature"].ToString();

    if (!Webhook.Verify(Environment.GetEnvironmentVariable("WEBHOOK_SECRET")!, rawBody, signature))
        return Results.BadRequest("Invalid signature");

    var json = System.Text.Encoding.UTF8.GetString(rawBody);
    // handle event
    return Results.Ok();
});
```

## Error Handling

```csharp
using CryptoGate.Exceptions;

try
{
    var tx = await cg.GetTransactionAsync("MTX-INVALID");
}
catch (NotFoundException ex)
{
    Console.WriteLine($"Not found: {ex.Message}");
}
catch (AuthenticationException ex)
{
    Console.WriteLine($"Auth error: {ex.Message}");
}
catch (CryptoGateException ex)
{
    Console.WriteLine($"{ex.ErrorCode}: {ex.Message} (HTTP {ex.HttpStatus})");
}
```

## License

MIT
