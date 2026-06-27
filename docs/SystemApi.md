# CryptoGate.Api.SystemApi

All URIs are relative to *https://api.cryptogate.live/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetHealth**](SystemApi.md#gethealth) | **GET** /health | API health check |
| [**HostedCheckoutRedirect**](SystemApi.md#hostedcheckoutredirect) | **GET** /pay | Hosted-checkout redirect (browser flow, publishable key) |

<a id="gethealth"></a>
# **GetHealth**
> GetHealth200Response GetHealth ()

API health check

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
    public class GetHealthExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cryptogate.live/v1";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SystemApi(httpClient, config, httpClientHandler);

            try
            {
                // API health check
                GetHealth200Response result = apiInstance.GetHealth();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemApi.GetHealth: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetHealthWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // API health check
    ApiResponse<GetHealth200Response> response = apiInstance.GetHealthWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemApi.GetHealthWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetHealth200Response**](GetHealth200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Service status (intentionally NOT wrapped in the success envelope). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="hostedcheckoutredirect"></a>
# **HostedCheckoutRedirect**
> void HostedCheckoutRedirect (string pk, string amount, CryptoSymbol crypto, string? link = null)

Hosted-checkout redirect (browser flow, publishable key)

Browser-facing redirect to the hosted payment page, authenticated by a **publishable** key in the query string (safe to expose client-side). Not used by the server-side SDKs — included for completeness. 

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
    public class HostedCheckoutRedirectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.cryptogate.live/v1";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SystemApi(httpClient, config, httpClientHandler);
            var pk = "pk_example";  // string | Publishable key, pk_live_… / pk_test_…
            var amount = "amount_example";  // string | Fiat amount (≥ 1.00 USD equivalent).
            var crypto = (CryptoSymbol) "BTC";  // CryptoSymbol | 
            var link = "link_example";  // string? | Payment-link slug for attribution. (optional) 

            try
            {
                // Hosted-checkout redirect (browser flow, publishable key)
                apiInstance.HostedCheckoutRedirect(pk, amount, crypto, link);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemApi.HostedCheckoutRedirect: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HostedCheckoutRedirectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Hosted-checkout redirect (browser flow, publishable key)
    apiInstance.HostedCheckoutRedirectWithHttpInfo(pk, amount, crypto, link);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemApi.HostedCheckoutRedirectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pk** | **string** | Publishable key, pk_live_… / pk_test_… |  |
| **amount** | **string** | Fiat amount (≥ 1.00 USD equivalent). |  |
| **crypto** | **CryptoSymbol** |  |  |
| **link** | **string?** | Payment-link slug for attribution. | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **302** | Redirect to https://cryptogate.live/transaction/{transaction_id} |  -  |
| **400** | Validation error (INVALID_REQUEST, INVALID_CRYPTO, INVALID_AMOUNT, AMOUNT_TOO_LOW, INVALID_CURRENCY, INVALID_METADATA, WALLET_NOT_CONFIGURED, MISSING_ITEMS, MISSING_ORDER_ID, …). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

