# CryptoGate.Api.AccountApi

All URIs are relative to *https://api.cryptogate.live/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAccount**](AccountApi.md#getaccount) | **GET** /account | Merchant plan, usage and limits |
| [**GetStats**](AccountApi.md#getstats) | **GET** /stats | Merchant transaction analytics |
| [**ListBalances**](AccountApi.md#listbalances) | **GET** /balances | On-platform balances (for overage/top-up; NOT crypto settlement) |
| [**ListInvoices**](AccountApi.md#listinvoices) | **GET** /invoices | CryptoGate billing invoices (platform ↔ merchant) |
| [**ListPlans**](AccountApi.md#listplans) | **GET** /plans | Plan catalogue and pricing |

<a id="getaccount"></a>
# **GetAccount**
> GetAccount200Response GetAccount ()

Merchant plan, usage and limits

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
    public class GetAccountExample
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
            var apiInstance = new AccountApi(httpClient, config, httpClientHandler);

            try
            {
                // Merchant plan, usage and limits
                GetAccount200Response result = apiInstance.GetAccount();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.GetAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Merchant plan, usage and limits
    ApiResponse<GetAccount200Response> response = apiInstance.GetAccountWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.GetAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetAccount200Response**](GetAccount200Response.md)

### Authorization

[SecretKey](../README.md#SecretKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Account details. |  -  |
| **401** | Missing or invalid API key (UNAUTHORIZED). |  -  |
| **403** | Key lacks permission — e.g. a publishable key on a secret-only endpoint, or plan too low (FORBIDDEN, USE_PAY_ENDPOINT, PLAN_UPGRADE_REQUIRED, NO_ACTIVE_PLAN). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getstats"></a>
# **GetStats**
> GetStats200Response GetStats ()

Merchant transaction analytics

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
    public class GetStatsExample
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
            var apiInstance = new AccountApi(httpClient, config, httpClientHandler);

            try
            {
                // Merchant transaction analytics
                GetStats200Response result = apiInstance.GetStats();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.GetStats: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStatsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Merchant transaction analytics
    ApiResponse<GetStats200Response> response = apiInstance.GetStatsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.GetStatsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetStats200Response**](GetStats200Response.md)

### Authorization

[SecretKey](../README.md#SecretKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Stats. |  -  |
| **401** | Missing or invalid API key (UNAUTHORIZED). |  -  |
| **403** | Key lacks permission — e.g. a publishable key on a secret-only endpoint, or plan too low (FORBIDDEN, USE_PAY_ENDPOINT, PLAN_UPGRADE_REQUIRED, NO_ACTIVE_PLAN). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listbalances"></a>
# **ListBalances**
> ListBalances200Response ListBalances ()

On-platform balances (for overage/top-up; NOT crypto settlement)

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
    public class ListBalancesExample
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
            var apiInstance = new AccountApi(httpClient, config, httpClientHandler);

            try
            {
                // On-platform balances (for overage/top-up; NOT crypto settlement)
                ListBalances200Response result = apiInstance.ListBalances();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.ListBalances: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListBalancesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // On-platform balances (for overage/top-up; NOT crypto settlement)
    ApiResponse<ListBalances200Response> response = apiInstance.ListBalancesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.ListBalancesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ListBalances200Response**](ListBalances200Response.md)

### Authorization

[SecretKey](../README.md#SecretKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Balances. |  -  |
| **401** | Missing or invalid API key (UNAUTHORIZED). |  -  |
| **403** | Key lacks permission — e.g. a publishable key on a secret-only endpoint, or plan too low (FORBIDDEN, USE_PAY_ENDPOINT, PLAN_UPGRADE_REQUIRED, NO_ACTIVE_PLAN). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listinvoices"></a>
# **ListInvoices**
> ListInvoices200Response ListInvoices (int? limit = null, int? offset = null)

CryptoGate billing invoices (platform ↔ merchant)

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
    public class ListInvoicesExample
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
            var apiInstance = new AccountApi(httpClient, config, httpClientHandler);
            var limit = 20;  // int? |  (optional)  (default to 20)
            var offset = 0;  // int? |  (optional)  (default to 0)

            try
            {
                // CryptoGate billing invoices (platform ↔ merchant)
                ListInvoices200Response result = apiInstance.ListInvoices(limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.ListInvoices: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListInvoicesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CryptoGate billing invoices (platform ↔ merchant)
    ApiResponse<ListInvoices200Response> response = apiInstance.ListInvoicesWithHttpInfo(limit, offset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.ListInvoicesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** |  | [optional] [default to 20] |
| **offset** | **int?** |  | [optional] [default to 0] |

### Return type

[**ListInvoices200Response**](ListInvoices200Response.md)

### Authorization

[SecretKey](../README.md#SecretKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Invoices. |  -  |
| **401** | Missing or invalid API key (UNAUTHORIZED). |  -  |
| **403** | Key lacks permission — e.g. a publishable key on a secret-only endpoint, or plan too low (FORBIDDEN, USE_PAY_ENDPOINT, PLAN_UPGRADE_REQUIRED, NO_ACTIVE_PLAN). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listplans"></a>
# **ListPlans**
> ListPlans200Response ListPlans ()

Plan catalogue and pricing

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
    public class ListPlansExample
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
            var apiInstance = new AccountApi(httpClient, config, httpClientHandler);

            try
            {
                // Plan catalogue and pricing
                ListPlans200Response result = apiInstance.ListPlans();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountApi.ListPlans: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPlansWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Plan catalogue and pricing
    ApiResponse<ListPlans200Response> response = apiInstance.ListPlansWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountApi.ListPlansWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ListPlans200Response**](ListPlans200Response.md)

### Authorization

[SecretKey](../README.md#SecretKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Plans. |  -  |
| **401** | Missing or invalid API key (UNAUTHORIZED). |  -  |
| **403** | Key lacks permission — e.g. a publishable key on a secret-only endpoint, or plan too low (FORBIDDEN, USE_PAY_ENDPOINT, PLAN_UPGRADE_REQUIRED, NO_ACTIVE_PLAN). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

