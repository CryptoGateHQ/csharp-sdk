# CryptoGate.Model.WebhookPayload
Payment-event payload. AMOUNTS ARE STRINGS (e.g. \"100.00\", \"0.00109462\") to preserve decimal precision — parse before arithmetic. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Event** | **string** |  | 
**Timestamp** | **DateTime** |  | 
**TransactionId** | **string** |  | 
**Status** | **TransactionStatus** |  | 
**CurrencyCrypto** | **CryptoSymbol** |  | [optional] 
**CurrencyFiat** | **FiatCurrency** |  | [optional] 
**AmountFiat** | **string** | Decimal string. | [optional] 
**AmountUsd** | **string** | Decimal string. | [optional] 
**AmountCrypto** | **string** | Decimal string. | [optional] 
**OrderId** | **string** |  | [optional] 
**ReceiptUrl** | **string** | Present on completed/overpaid. | [optional] 
**Metadata** | **Dictionary&lt;string, string&gt;** | Free-form key/value (≤20 keys, string values ≤500 chars, ≤4 KB total). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

