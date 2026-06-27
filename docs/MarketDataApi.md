# CryptoGate.Api.MarketDataApi

All URIs are relative to *https://api.cryptogate.live/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetPrices**](MarketDataApi.md#getprices) | **GET** /prices | Current crypto and fiat exchange rates (USD-denominated) |
| [**ListCryptocurrencies**](MarketDataApi.md#listcryptocurrencies) | **GET** /cryptos/list | All supported cryptocurrencies and tokens |
| [**ListMerchantCryptocurrencies**](MarketDataApi.md#listmerchantcryptocurrencies) | **GET** /merchant/cryptos | Cryptocurrencies this merchant has wallets configured for |

<a id="getprices"></a>
# **GetPrices**
> GetPrices200Response GetPrices ()

Current crypto and fiat exchange rates (USD-denominated)

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
    public class GetPricesExample
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
            var apiInstance = new MarketDataApi(httpClient, config, httpClientHandler);

            try
            {
                // Current crypto and fiat exchange rates (USD-denominated)
                GetPrices200Response result = apiInstance.GetPrices();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketDataApi.GetPrices: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPricesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Current crypto and fiat exchange rates (USD-denominated)
    ApiResponse<GetPrices200Response> response = apiInstance.GetPricesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarketDataApi.GetPricesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetPrices200Response**](GetPrices200Response.md)

### Authorization

[SecretKey](../README.md#SecretKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Live rates. |  -  |
| **401** | Missing or invalid API key (UNAUTHORIZED). |  -  |
| **500** | Internal error (RATE_FETCH_FAILED, ADDRESS_GENERATION_FAILED, MIDAS_ERROR, …). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listcryptocurrencies"></a>
# **ListCryptocurrencies**
> ListCryptocurrencies200Response ListCryptocurrencies ()

All supported cryptocurrencies and tokens

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
    public class ListCryptocurrenciesExample
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
            var apiInstance = new MarketDataApi(httpClient, config, httpClientHandler);

            try
            {
                // All supported cryptocurrencies and tokens
                ListCryptocurrencies200Response result = apiInstance.ListCryptocurrencies();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketDataApi.ListCryptocurrencies: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCryptocurrenciesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // All supported cryptocurrencies and tokens
    ApiResponse<ListCryptocurrencies200Response> response = apiInstance.ListCryptocurrenciesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarketDataApi.ListCryptocurrenciesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ListCryptocurrencies200Response**](ListCryptocurrencies200Response.md)

### Authorization

[SecretKey](../README.md#SecretKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Supported-currency catalogue. |  -  |
| **401** | Missing or invalid API key (UNAUTHORIZED). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listmerchantcryptocurrencies"></a>
# **ListMerchantCryptocurrencies**
> ListCryptocurrencies200Response ListMerchantCryptocurrencies ()

Cryptocurrencies this merchant has wallets configured for

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
    public class ListMerchantCryptocurrenciesExample
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
            var apiInstance = new MarketDataApi(httpClient, config, httpClientHandler);

            try
            {
                // Cryptocurrencies this merchant has wallets configured for
                ListCryptocurrencies200Response result = apiInstance.ListMerchantCryptocurrencies();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketDataApi.ListMerchantCryptocurrencies: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListMerchantCryptocurrenciesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cryptocurrencies this merchant has wallets configured for
    ApiResponse<ListCryptocurrencies200Response> response = apiInstance.ListMerchantCryptocurrenciesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MarketDataApi.ListMerchantCryptocurrenciesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ListCryptocurrencies200Response**](ListCryptocurrencies200Response.md)

### Authorization

[SecretKey](../README.md#SecretKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The merchant&#39;s configured currencies. |  -  |
| **401** | Missing or invalid API key (UNAUTHORIZED). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

