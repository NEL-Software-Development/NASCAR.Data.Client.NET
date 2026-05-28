# NASCAR.Data.Client.Api.InspectionsApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InspectionsOssGet**](InspectionsApi.md#inspectionsossget) | **GET** /inspections/oss | Retrieves a list of OSS scans for a specific race.
[**InspectionsVehicleWeightsGet**](InspectionsApi.md#inspectionsvehicleweightsget) | **GET** /inspections/vehicle-weights | Retrieves a list of vehicle weights for a specific race.

<a name="inspectionsossget"></a>
# **InspectionsOssGet**
> Collection<OSSScan> InspectionsOssGet (int? raceId = null)

Retrieves a list of OSS scans for a specific race.

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class InspectionsOssGetExample
    {
        public void main()
        {

            var apiInstance = new InspectionsApi();
            var raceId = 56;  // int? | Unique race identifier. (optional) 

            try
            {
                // Retrieves a list of OSS scans for a specific race.
                Collection&lt;OSSScan&gt; result = apiInstance.InspectionsOssGet(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InspectionsApi.InspectionsOssGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **raceId** | **int?**| Unique race identifier. | [optional] 

### Return type

[**Collection<OSSScan>**](OSSScan.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="inspectionsvehicleweightsget"></a>
# **InspectionsVehicleWeightsGet**
> Collection<VehicleWeight> InspectionsVehicleWeightsGet (int? raceId = null)

Retrieves a list of vehicle weights for a specific race.

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class InspectionsVehicleWeightsGetExample
    {
        public void main()
        {

            var apiInstance = new InspectionsApi();
            var raceId = 56;  // int? | Unique race identifier. (optional) 

            try
            {
                // Retrieves a list of vehicle weights for a specific race.
                Collection&lt;VehicleWeight&gt; result = apiInstance.InspectionsVehicleWeightsGet(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InspectionsApi.InspectionsVehicleWeightsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **raceId** | **int?**| Unique race identifier. | [optional] 

### Return type

[**Collection<VehicleWeight>**](VehicleWeight.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
