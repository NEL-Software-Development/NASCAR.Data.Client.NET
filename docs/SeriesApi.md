# NASCAR.Data.Client.Api.SeriesApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Series**](SeriesApi.md#series) | **GET** /series | 

<a name="series"></a>
# **Series**
> Collection<Series> Series ()



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class SeriesExample
    {
        public void main()
        {

            var apiInstance = new SeriesApi();

            try
            {
                Collection&lt;Series&gt; result = apiInstance.Series();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SeriesApi.Series: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Collection<Series>**](Series.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
