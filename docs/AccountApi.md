# NASCAR.Data.Client.Api.AccountApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RefreshToken**](AccountApi.md#refreshtoken) | **GET** /account/refresh-token | 

<a name="refreshtoken"></a>
# **RefreshToken**
> TokenResponse RefreshToken (string refreshToken = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class RefreshTokenExample
    {
        public void main()
        {

            var apiInstance = new AccountApi();
            var refreshToken = refreshToken_example;  // string |  (optional) 

            try
            {
                TokenResponse result = apiInstance.RefreshToken(refreshToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.RefreshToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **refreshToken** | **string**|  | [optional] 

### Return type

[**TokenResponse**](TokenResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
