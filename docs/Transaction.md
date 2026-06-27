# CryptoGate.Model.Transaction
The canonical, curated public view of a transaction (same shape from create, get and list). Internal fields (capability tokens, client_ip, address_index, derivation/db internals) are deliberately NOT exposed. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionId** | **string** |  | 
**Status** | **TransactionStatus** |  | 
**Type** | **string** |  | [optional] 
**Crypto** | **CryptoSymbol** |  | 
**DepositAddress** | **string** |  | [optional] 
**AmountCrypto** | **decimal** |  | [optional] 
**AmountFiat** | **decimal** |  | 
**AmountUsd** | **decimal** |  | 
**AmountPaid** | **decimal** |  | [optional] 
**AmountRemaining** | **decimal** |  | [optional] 
**CurrencyFiat** | **FiatCurrency** |  | 
**FiatToUsdRate** | **decimal** |  | [optional] 
**ExchangeRate** | **decimal** | USD per unit of crypto, locked at creation. | [optional] 
**ConfirmationsRequired** | **int** |  | [optional] 
**PaymentUrl** | **string** |  | [optional] 
**OrderId** | **string** |  | [optional] 
**CustomerEmail** | **string** |  | [optional] 
**Items** | [**List&lt;LineItem&gt;**](LineItem.md) |  | [optional] 
**Payments** | [**List&lt;PaymentSplit&gt;**](PaymentSplit.md) | On-chain payments detected toward this transaction. | [optional] 
**Metadata** | **Dictionary&lt;string, string&gt;** | Free-form key/value (≤20 keys, string values ≤500 chars, ≤4 KB total). | [optional] 
**SuccessUrl** | **string** |  | [optional] 
**CancelUrl** | **string** |  | [optional] 
**CreatedAt** | **DateTime** |  | 
**UpdatedAt** | **DateTime** |  | [optional] 
**ExpiresAt** | **DateTime** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

