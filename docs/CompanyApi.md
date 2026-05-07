# NASCAR.Data.Client.Api.CompanyApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CompanyGet**](CompanyApi.md#companyget) | **GET** /company | Retrieves a single company by ID.
[**CompanySearchGet**](CompanyApi.md#companysearchget) | **GET** /company/search | Searches for companies by name or keyword.

<a name="companyget"></a>
# **CompanyGet**
> Company CompanyGet (int? id = null)

Retrieves a single company by ID.

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class CompanyGetExample
    {
        public void main()
        {

            var apiInstance = new CompanyApi();
            var id = 56;  // int? | Unique company identifier. (optional) 

            try
            {
                // Retrieves a single company by ID.
                Company result = apiInstance.CompanyGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyApi.CompanyGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Unique company identifier. | [optional] 

### Return type

[**Company**](Company.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="companysearchget"></a>
# **CompanySearchGet**
> Collection<Company> CompanySearchGet (string searchTerm = null)

Searches for companies by name or keyword.

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
            var searchTerm = searchTerm_example;  // string | Partial or full company name to search for (e.g. \"Daytona\"). (optional) 

            try
            {
                // Searches for companies by name or keyword.
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
 **searchTerm** | **string**| Partial or full company name to search for (e.g. \&quot;Daytona\&quot;). | [optional] 

### Return type

[**Collection<Company>**](Company.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
