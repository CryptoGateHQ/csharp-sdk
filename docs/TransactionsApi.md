# CryptoGate.Api.TransactionsApi

All URIs are relative to *https://api.cryptogate.live/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateDetailedTransaction**](TransactionsApi.md#createdetailedtransaction) | **POST** /transactions/create-detailed | Create an itemized transaction (Professional/Enterprise plans) |
| [**CreateTransaction**](TransactionsApi.md#createtransaction) | **POST** /transactions/create | Create a payment transaction |
| [**GetTransaction**](TransactionsApi.md#gettransaction) | **GET** /transactions/{transaction_id} | Retrieve a single transaction |
| [**ListTransactions**](TransactionsApi.md#listtransactions) | **GET** /transactions/list | List the merchant&#39;s transactions (newest first) |

<a id="createdetailedtransaction"></a>
# **CreateDetailedTransaction**
> TransactionEnvelope CreateDetailedTransaction (CreateDetailedTransactionRequest createDetailedTransactionRequest, string? xIdempotencyKey = null)

Create an itemized transaction (Professional/Enterprise plans)

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
    public class CreateDetailedTransactionExample
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
            var apiInstance = new TransactionsApi(httpClient, config, httpClientHandler);
            var createDetailedTransactionRequest = new CreateDetailedTransactionRequest(); // CreateDetailedTransactionRequest | 
            var xIdempotencyKey = "xIdempotencyKey_example";  // string? | Optional unique key for a create request (e.g. a UUID). A retried create with the same key returns the original transaction instead of creating a duplicate — send it on every create so a network retry can't double-charge the customer.  (optional) 

            try
            {
                // Create an itemized transaction (Professional/Enterprise plans)
                TransactionEnvelope result = apiInstance.CreateDetailedTransaction(createDetailedTransactionRequest, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.CreateDetailedTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateDetailedTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an itemized transaction (Professional/Enterprise plans)
    ApiResponse<TransactionEnvelope> response = apiInstance.CreateDetailedTransactionWithHttpInfo(createDetailedTransactionRequest, xIdempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.CreateDetailedTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createDetailedTransactionRequest** | [**CreateDetailedTransactionRequest**](CreateDetailedTransactionRequest.md) |  |  |
| **xIdempotencyKey** | **string?** | Optional unique key for a create request (e.g. a UUID). A retried create with the same key returns the original transaction instead of creating a duplicate — send it on every create so a network retry can&#39;t double-charge the customer.  | [optional]  |

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
| **201** | Transaction created. |  -  |
| **400** | Validation error (INVALID_REQUEST, INVALID_CRYPTO, INVALID_AMOUNT, AMOUNT_TOO_LOW, INVALID_CURRENCY, INVALID_METADATA, WALLET_NOT_CONFIGURED, MISSING_ITEMS, MISSING_ORDER_ID, …). |  -  |
| **401** | Missing or invalid API key (UNAUTHORIZED). |  -  |
| **402** | Merchant platform balance too low for overage fees (INSUFFICIENT_BALANCE). |  -  |
| **403** | Key lacks permission — e.g. a publishable key on a secret-only endpoint, or plan too low (FORBIDDEN, USE_PAY_ENDPOINT, PLAN_UPGRADE_REQUIRED, NO_ACTIVE_PLAN). |  -  |
| **429** | Rate limit or quota exceeded. &#x60;error&#x60; is &#x60;RATE_LIMIT_EXCEEDED&#x60; (per-minute request rate — honour &#x60;Retry-After&#x60;) or &#x60;MONTHLY_LIMIT_REACHED&#x60; (the plan&#39;s monthly transaction quota). Rate-limit headers accompany the &#x60;RATE_LIMIT_EXCEEDED&#x60; case.  |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  * Retry-After -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createtransaction"></a>
# **CreateTransaction**
> TransactionEnvelope CreateTransaction (CreateTransactionRequest createTransactionRequest, string? xIdempotencyKey = null)

Create a payment transaction

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
    public class CreateTransactionExample
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
            var apiInstance = new TransactionsApi(httpClient, config, httpClientHandler);
            var createTransactionRequest = new CreateTransactionRequest(); // CreateTransactionRequest | 
            var xIdempotencyKey = "xIdempotencyKey_example";  // string? | Optional unique key for a create request (e.g. a UUID). A retried create with the same key returns the original transaction instead of creating a duplicate — send it on every create so a network retry can't double-charge the customer.  (optional) 

            try
            {
                // Create a payment transaction
                TransactionEnvelope result = apiInstance.CreateTransaction(createTransactionRequest, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.CreateTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a payment transaction
    ApiResponse<TransactionEnvelope> response = apiInstance.CreateTransactionWithHttpInfo(createTransactionRequest, xIdempotencyKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.CreateTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createTransactionRequest** | [**CreateTransactionRequest**](CreateTransactionRequest.md) |  |  |
| **xIdempotencyKey** | **string?** | Optional unique key for a create request (e.g. a UUID). A retried create with the same key returns the original transaction instead of creating a duplicate — send it on every create so a network retry can&#39;t double-charge the customer.  | [optional]  |

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
| **201** | Transaction created. |  -  |
| **400** | Validation error (INVALID_REQUEST, INVALID_CRYPTO, INVALID_AMOUNT, AMOUNT_TOO_LOW, INVALID_CURRENCY, INVALID_METADATA, WALLET_NOT_CONFIGURED, MISSING_ITEMS, MISSING_ORDER_ID, …). |  -  |
| **401** | Missing or invalid API key (UNAUTHORIZED). |  -  |
| **402** | Merchant platform balance too low for overage fees (INSUFFICIENT_BALANCE). |  -  |
| **403** | Key lacks permission — e.g. a publishable key on a secret-only endpoint, or plan too low (FORBIDDEN, USE_PAY_ENDPOINT, PLAN_UPGRADE_REQUIRED, NO_ACTIVE_PLAN). |  -  |
| **409** | This client IP already has an active transaction (ACTIVE_TRANSACTION_EXISTS). Body includes an &#x60;existing_transaction&#x60; object. |  -  |
| **429** | Rate limit or quota exceeded. &#x60;error&#x60; is &#x60;RATE_LIMIT_EXCEEDED&#x60; (per-minute request rate — honour &#x60;Retry-After&#x60;) or &#x60;MONTHLY_LIMIT_REACHED&#x60; (the plan&#39;s monthly transaction quota). Rate-limit headers accompany the &#x60;RATE_LIMIT_EXCEEDED&#x60; case.  |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  * Retry-After -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettransaction"></a>
# **GetTransaction**
> TransactionEnvelope GetTransaction (string transactionId)

Retrieve a single transaction

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
    public class GetTransactionExample
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
            var apiInstance = new TransactionsApi(httpClient, config, httpClientHandler);
            var transactionId = "transactionId_example";  // string | 

            try
            {
                // Retrieve a single transaction
                TransactionEnvelope result = apiInstance.GetTransaction(transactionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.GetTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a single transaction
    ApiResponse<TransactionEnvelope> response = apiInstance.GetTransactionWithHttpInfo(transactionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.GetTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transactionId** | **string** |  |  |

### Return type

[**TransactionEnvelope**](TransactionEnvelope.md)

### Authorization

[SecretKey](../README.md#SecretKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The transaction. |  -  |
| **401** | Missing or invalid API key (UNAUTHORIZED). |  -  |
| **403** | Key lacks permission — e.g. a publishable key on a secret-only endpoint, or plan too low (FORBIDDEN, USE_PAY_ENDPOINT, PLAN_UPGRADE_REQUIRED, NO_ACTIVE_PLAN). |  -  |
| **404** | Resource not found (TRANSACTION_NOT_FOUND). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listtransactions"></a>
# **ListTransactions**
> ListTransactions200Response ListTransactions (int? limit = null, int? offset = null, TransactionStatus? status = null, CryptoSymbol? crypto = null)

List the merchant's transactions (newest first)

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
    public class ListTransactionsExample
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
            var apiInstance = new TransactionsApi(httpClient, config, httpClientHandler);
            var limit = 20;  // int? |  (optional)  (default to 20)
            var offset = 0;  // int? |  (optional)  (default to 0)
            var status = new TransactionStatus?(); // TransactionStatus? |  (optional) 
            var crypto = new CryptoSymbol?(); // CryptoSymbol? |  (optional) 

            try
            {
                // List the merchant's transactions (newest first)
                ListTransactions200Response result = apiInstance.ListTransactions(limit, offset, status, crypto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.ListTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List the merchant's transactions (newest first)
    ApiResponse<ListTransactions200Response> response = apiInstance.ListTransactionsWithHttpInfo(limit, offset, status, crypto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.ListTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** |  | [optional] [default to 20] |
| **offset** | **int?** |  | [optional] [default to 0] |
| **status** | [**TransactionStatus?**](TransactionStatus?.md) |  | [optional]  |
| **crypto** | [**CryptoSymbol?**](CryptoSymbol?.md) |  | [optional]  |

### Return type

[**ListTransactions200Response**](ListTransactions200Response.md)

### Authorization

[SecretKey](../README.md#SecretKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A page of transactions. |  -  |
| **401** | Missing or invalid API key (UNAUTHORIZED). |  -  |
| **403** | Key lacks permission — e.g. a publishable key on a secret-only endpoint, or plan too low (FORBIDDEN, USE_PAY_ENDPOINT, PLAN_UPGRADE_REQUIRED, NO_ACTIVE_PLAN). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

