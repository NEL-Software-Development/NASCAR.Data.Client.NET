# NASCAR.Data.Client.Api.DriverSummaryApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DriverSummary**](DriverSummaryApi.md#driversummary) | **GET** /driver-summary | 

<a name="driversummary"></a>
# **DriverSummary**
> Collection<DriverSummary> DriverSummary (int? seriesId = null, int? season = null, int? driverId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class DriverSummaryExample
    {
        public void main()
        {

            var apiInstance = new DriverSummaryApi();
            var seriesId = 56;  // int? |  (optional) 
            var season = 56;  // int? |  (optional) 
            var driverId = 56;  // int? |  (optional)  (default to 0)

            try
            {
                Collection&lt;DriverSummary&gt; result = apiInstance.DriverSummary(seriesId, season, driverId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DriverSummaryApi.DriverSummary: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **seriesId** | **int?**|  | [optional] 
 **season** | **int?**|  | [optional] 
 **driverId** | **int?**|  | [optional] [default to 0]

### Return type

[**Collection<DriverSummary>**](DriverSummary.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
