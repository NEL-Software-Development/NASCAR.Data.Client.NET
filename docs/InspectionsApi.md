# NASCAR.Data.Client.Api.InspectionsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OSS**](InspectionsApi.md#oss) | **GET** /inspections/oss | 
[**VehicleWeights**](InspectionsApi.md#vehicleweights) | **GET** /inspections/vehicle-weights | 

<a name="oss"></a>
# **OSS**
> Collection<OSSScan> OSS (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class OSSExample
    {
        public void main()
        {

            var apiInstance = new InspectionsApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;OSSScan&gt; result = apiInstance.OSS(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InspectionsApi.OSS: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **raceId** | **int?**|  | [optional] 

### Return type

[**Collection<OSSScan>**](OSSScan.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="vehicleweights"></a>
# **VehicleWeights**
> Collection<VehicleWeight> VehicleWeights (int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class VehicleWeightsExample
    {
        public void main()
        {

            var apiInstance = new InspectionsApi();
            var raceId = 56;  // int? |  (optional) 

            try
            {
                Collection&lt;VehicleWeight&gt; result = apiInstance.VehicleWeights(raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InspectionsApi.VehicleWeights: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **raceId** | **int?**|  | [optional] 

### Return type

[**Collection<VehicleWeight>**](VehicleWeight.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
