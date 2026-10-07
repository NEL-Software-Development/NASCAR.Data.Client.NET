# NASCAR.Data.Client.Api.AccountApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountRefreshTokenGet**](AccountApi.md#accountrefreshtokenget) | **GET** /account/refresh-token | Refreshes an expired authentication token using a refresh token.

<a name="accountrefreshtokenget"></a>
# **AccountRefreshTokenGet**
> TokenResponse AccountRefreshTokenGet (string refreshToken = null)

Refreshes an expired authentication token using a refresh token.

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class AccountRefreshTokenGetExample
    {
        public void main()
        {

            var apiInstance = new AccountApi();
            var refreshToken = refreshToken_example;  // string | The refresh token obtained from a previous authentication.  Used to obtain a new access token without requiring user credentials. (optional) 

            try
            {
                // Refreshes an expired authentication token using a refresh token.
                TokenResponse result = apiInstance.AccountRefreshTokenGet(refreshToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AccountRefreshTokenGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **refreshToken** | **string**| The refresh token obtained from a previous authentication.  Used to obtain a new access token without requiring user credentials. | [optional] 

### Return type

[**TokenResponse**](TokenResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
