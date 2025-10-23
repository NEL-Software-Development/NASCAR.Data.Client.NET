# NASCAR.Data.Client.Api.VehicleApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**VehicleGet**](VehicleApi.md#vehicleget) | **GET** /vehicle | 
[**VehicleSeasonFinishesGet**](VehicleApi.md#vehicleseasonfinishesget) | **GET** /vehicle/season-finishes | 

<a name="vehicleget"></a>
# **VehicleGet**
> VehicleDetails VehicleGet (int? id = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class VehicleGetExample
    {
        public void main()
        {

            var apiInstance = new VehicleApi();
            var id = 56;  // int? |  (optional) 

            try
            {
                VehicleDetails result = apiInstance.VehicleGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VehicleApi.VehicleGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | [optional] 

### Return type

[**VehicleDetails**](VehicleDetails.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="vehicleseasonfinishesget"></a>
# **VehicleSeasonFinishesGet**
> Collection<RaceResultSummary> VehicleSeasonFinishesGet (int? season = null, int? seriesId = null, string vehicle = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class VehicleSeasonFinishesGetExample
    {
        public void main()
        {

            var apiInstance = new VehicleApi();
            var season = 56;  // int? |  (optional) 
            var seriesId = 56;  // int? |  (optional) 
            var vehicle = vehicle_example;  // string |  (optional) 

            try
            {
                Collection&lt;RaceResultSummary&gt; result = apiInstance.VehicleSeasonFinishesGet(season, seriesId, vehicle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VehicleApi.VehicleSeasonFinishesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **season** | **int?**|  | [optional] 
 **seriesId** | **int?**|  | [optional] 
 **vehicle** | **string**|  | [optional] 

### Return type

[**Collection<RaceResultSummary>**](RaceResultSummary.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
