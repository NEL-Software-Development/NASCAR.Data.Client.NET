# NASCAR.Data.Client.Api.PointsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DriverPoints**](PointsApi.md#driverpoints) | **GET** /points/driver-points | 
[**ManufacturerPoints**](PointsApi.md#manufacturerpoints) | **GET** /points/manufacturer-points | 
[**OwnerPoints**](PointsApi.md#ownerpoints) | **GET** /points/owner-points | 

<a name="driverpoints"></a>
# **DriverPoints**
> Collection<DriverPoint> DriverPoints (int? season = null, int? seriesId = null, int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class DriverPointsExample
    {
        public void main()
        {

            var apiInstance = new PointsApi();
            var season = 56;  // int? |  (optional) 
            var seriesId = 56;  // int? |  (optional) 
            var raceId = 56;  // int? |  (optional)  (default to 0)

            try
            {
                Collection&lt;DriverPoint&gt; result = apiInstance.DriverPoints(season, seriesId, raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PointsApi.DriverPoints: " + e.Message );
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
 **raceId** | **int?**|  | [optional] [default to 0]

### Return type

[**Collection<DriverPoint>**](DriverPoint.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="manufacturerpoints"></a>
# **ManufacturerPoints**
> Collection<ManufacturerPoint> ManufacturerPoints (int? season = null, int? seriesId = null, int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class ManufacturerPointsExample
    {
        public void main()
        {

            var apiInstance = new PointsApi();
            var season = 56;  // int? |  (optional) 
            var seriesId = 56;  // int? |  (optional) 
            var raceId = 56;  // int? |  (optional)  (default to 0)

            try
            {
                Collection&lt;ManufacturerPoint&gt; result = apiInstance.ManufacturerPoints(season, seriesId, raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PointsApi.ManufacturerPoints: " + e.Message );
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
 **raceId** | **int?**|  | [optional] [default to 0]

### Return type

[**Collection<ManufacturerPoint>**](ManufacturerPoint.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="ownerpoints"></a>
# **OwnerPoints**
> Collection<OwnerPoint> OwnerPoints (int? season = null, int? seriesId = null, int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class OwnerPointsExample
    {
        public void main()
        {

            var apiInstance = new PointsApi();
            var season = 56;  // int? |  (optional) 
            var seriesId = 56;  // int? |  (optional) 
            var raceId = 56;  // int? |  (optional)  (default to 0)

            try
            {
                Collection&lt;OwnerPoint&gt; result = apiInstance.OwnerPoints(season, seriesId, raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PointsApi.OwnerPoints: " + e.Message );
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
 **raceId** | **int?**|  | [optional] [default to 0]

### Return type

[**Collection<OwnerPoint>**](OwnerPoint.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
