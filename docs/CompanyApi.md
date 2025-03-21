# NASCAR.Data.Client.Api.CompanyApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CompanySearchGet**](CompanyApi.md#companysearchget) | **GET** /company/search | 

<a name="companysearchget"></a>
# **CompanySearchGet**
> Collection<Company> CompanySearchGet (string searchTerm = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class CompanySearchGetExample
    {
        public void main()
        {

            var apiInstance = new CompanyApi();
            var searchTerm = searchTerm_example;  // string |  (optional) 

            try
            {
                Collection&lt;Company&gt; result = apiInstance.CompanySearchGet(searchTerm);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyApi.CompanySearchGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchTerm** | **string**|  | [optional] 

### Return type

[**Collection<Company>**](Company.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
