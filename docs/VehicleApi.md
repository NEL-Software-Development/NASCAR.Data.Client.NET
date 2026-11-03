# NASCAR.Data.Client.Api.VehicleApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**VehicleGet**](VehicleApi.md#vehicleget) | **GET** /vehicle | Retrieves detailed information about a specific vehicle, including its finishes, given the vehicle&#x27;s unique identifier.
[**VehicleSeasonFinishesGet**](VehicleApi.md#vehicleseasonfinishesget) | **GET** /vehicle/season-finishes | Retrieves a list of all finishes for a specific vehicle across an entire season, given the season, series, and vehicle number.

<a name="vehicleget"></a>
# **VehicleGet**
> VehicleDetails VehicleGet (int? id = null)

Retrieves detailed information about a specific vehicle, including its finishes, given the vehicle's unique identifier.

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
            var id = 56;  // int? | The unique identifier of the vehicle. (optional) 

            try
            {
                // Retrieves detailed information about a specific vehicle, including its finishes, given the vehicle's unique identifier.
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
 **id** | **int?**| The unique identifier of the vehicle. | [optional] 

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

Retrieves a list of all finishes for a specific vehicle across an entire season, given the season, series, and vehicle number.

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
            var season = 56;  // int? | Four-digit season year to query (optional) 
            var seriesId = 56;  // int? | Series identifier. Common values are 1 for Cup, 2 for O'Reilly, and 3 for Truck. (optional) 
            var vehicle = vehicle_example;  // string | Vehicle number to query (optional) 

            try
            {
                // Retrieves a list of all finishes for a specific vehicle across an entire season, given the season, series, and vehicle number.
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
 **season** | **int?**| Four-digit season year to query | [optional] 
 **seriesId** | **int?**| Series identifier. Common values are 1 for Cup, 2 for O&#x27;Reilly, and 3 for Truck. | [optional] 
 **vehicle** | **string**| Vehicle number to query | [optional] 

### Return type

[**Collection<RaceResultSummary>**](RaceResultSummary.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
