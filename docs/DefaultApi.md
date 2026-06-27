# CryptoGate.Api.DefaultApi

All URIs are relative to *https://api.cryptogate.live/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PaymentWebhook**](DefaultApi.md#paymentwebhook) | **POST** /paymentEvent | Payment lifecycle event delivered to the merchant&#39;s webhook URL |

<a id="paymentwebhook"></a>
# **PaymentWebhook**
> void PaymentWebhook (WebhookPayload? webhookPayload = null)

Payment lifecycle event delivered to the merchant's webhook URL

Signed with HMAC-SHA256 over the RAW request body. Verify by comparing `X-CryptoGate-Signature: sha256=<hex>` to `hex(hmac_sha256(webhook_secret, raw_body))` using a constant-time compare. Also sent: `X-CryptoGate-Event` (the event type) and `X-Webhook-ID` (unique delivery id — use for idempotency). 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using CryptoGate.Api;
using CryptoGate.Client;
using CryptoGate.Model;

namespace Example
{
    public class PaymentWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cryptogate.live/v1";
            // Configure Bearer token for authorization: SecretKey
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
            var webhookPayload = new WebhookPayload?(); // WebhookPayload? |  (optional) 

            try
            {
                // Payment lifecycle event delivered to the merchant's webhook URL
                apiInstance.PaymentWebhook(webhookPayload);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.PaymentWebhook: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PaymentWebhookWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Payment lifecycle event delivered to the merchant's webhook URL
    apiInstance.PaymentWebhookWithHttpInfo(webhookPayload);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.PaymentWebhookWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhookPayload** | [**WebhookPayload?**](WebhookPayload?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[SecretKey](../README.md#SecretKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Acknowledge within 15s. Non-2xx is retried with backoff. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

