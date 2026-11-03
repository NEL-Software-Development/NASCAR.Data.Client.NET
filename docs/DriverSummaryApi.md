# NASCAR.Data.Client.Api.DriverSummaryApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DriverSummaryGet**](DriverSummaryApi.md#driversummaryget) | **GET** /driver-summary | Returns a summary of a driver&#x27;s performance for a given series and season, including statistics such as wins, top 5s, top 10s, poles, and more.

<a name="driversummaryget"></a>
# **DriverSummaryGet**
> Collection<DriverSummary> DriverSummaryGet (int? seriesId = null, int? season = null, int? driverId = null)

Returns a summary of a driver's performance for a given series and season, including statistics such as wins, top 5s, top 10s, poles, and more.

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class DriverSummaryGetExample
    {
        public void main()
        {

            var apiInstance = new DriverSummaryApi();
            var seriesId = 56;  // int? | Series identifier. Common values are 1 for Cup, 2 for O'Reilly, and 3 for Truck. (optional) 
            var season = 56;  // int? | Four-digit season year to query. (optional) 
            var driverId = 56;  // int? | Unique driver identifier. If specified, the summary will be limited to the given driver. If not provided or set to 0, summaries for all drivers in the specified series and season will be returned. (optional)  (default to 0)

            try
            {
                // Returns a summary of a driver's performance for a given series and season, including statistics such as wins, top 5s, top 10s, poles, and more.
                Collection&lt;DriverSummary&gt; result = apiInstance.DriverSummaryGet(seriesId, season, driverId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DriverSummaryApi.DriverSummaryGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **seriesId** | **int?**| Series identifier. Common values are 1 for Cup, 2 for O&#x27;Reilly, and 3 for Truck. | [optional] 
 **season** | **int?**| Four-digit season year to query. | [optional] 
 **driverId** | **int?**| Unique driver identifier. If specified, the summary will be limited to the given driver. If not provided or set to 0, summaries for all drivers in the specified series and season will be returned. | [optional] [default to 0]

### Return type

[**Collection<DriverSummary>**](DriverSummary.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
