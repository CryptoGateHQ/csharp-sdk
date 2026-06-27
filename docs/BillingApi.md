# CryptoGate.Api.BillingApi

All URIs are relative to *https://api.cryptogate.live/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateBillingCheckout**](BillingApi.md#createbillingcheckout) | **POST** /billing/checkout | Start a plan upgrade or account top-up |

<a id="createbillingcheckout"></a>
# **CreateBillingCheckout**
> TransactionEnvelope CreateBillingCheckout (CreateBillingCheckoutRequest createBillingCheckoutRequest)

Start a plan upgrade or account top-up

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
    public class CreateBillingCheckoutExample
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
            var apiInstance = new BillingApi(httpClient, config, httpClientHandler);
            var createBillingCheckoutRequest = new CreateBillingCheckoutRequest(); // CreateBillingCheckoutRequest | 

            try
            {
                // Start a plan upgrade or account top-up
                TransactionEnvelope result = apiInstance.CreateBillingCheckout(createBillingCheckoutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BillingApi.CreateBillingCheckout: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateBillingCheckoutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Start a plan upgrade or account top-up
    ApiResponse<TransactionEnvelope> response = apiInstance.CreateBillingCheckoutWithHttpInfo(createBillingCheckoutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BillingApi.CreateBillingCheckoutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createBillingCheckoutRequest** | [**CreateBillingCheckoutRequest**](CreateBillingCheckoutRequest.md) |  |  |

### Return type

[**TransactionEnvelope**](TransactionEnvelope.md)

### Authorization

[SecretKey](../README.md#SecretKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Billing transaction created. |  -  |
| **401** | Missing or invalid API key (UNAUTHORIZED). |  -  |
| **402** | Merchant platform balance too low for overage fees (INSUFFICIENT_BALANCE). |  -  |
| **403** | Key lacks permission — e.g. a publishable key on a secret-only endpoint, or plan too low (FORBIDDEN, USE_PAY_ENDPOINT, PLAN_UPGRADE_REQUIRED, NO_ACTIVE_PLAN). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

