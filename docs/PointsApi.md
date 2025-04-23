# NASCAR.Data.Client.Api.PointsApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PointsDriverPointsGet**](PointsApi.md#pointsdriverpointsget) | **GET** /points/driver-points | 
[**PointsManufacturerPointsGet**](PointsApi.md#pointsmanufacturerpointsget) | **GET** /points/manufacturer-points | 
[**PointsOwnerPointsGet**](PointsApi.md#pointsownerpointsget) | **GET** /points/owner-points | 

<a name="pointsdriverpointsget"></a>
# **PointsDriverPointsGet**
> Collection<DriverPoint> PointsDriverPointsGet (int? season = null, int? seriesId = null, int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class PointsDriverPointsGetExample
    {
        public void main()
        {

            var apiInstance = new PointsApi();
            var season = 56;  // int? |  (optional) 
            var seriesId = 56;  // int? |  (optional) 
            var raceId = 56;  // int? |  (optional)  (default to 0)

            try
            {
                Collection&lt;DriverPoint&gt; result = apiInstance.PointsDriverPointsGet(season, seriesId, raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PointsApi.PointsDriverPointsGet: " + e.Message );
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
<a name="pointsmanufacturerpointsget"></a>
# **PointsManufacturerPointsGet**
> Collection<ManufacturerPoint> PointsManufacturerPointsGet (int? season = null, int? seriesId = null, int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class PointsManufacturerPointsGetExample
    {
        public void main()
        {

            var apiInstance = new PointsApi();
            var season = 56;  // int? |  (optional) 
            var seriesId = 56;  // int? |  (optional) 
            var raceId = 56;  // int? |  (optional)  (default to 0)

            try
            {
                Collection&lt;ManufacturerPoint&gt; result = apiInstance.PointsManufacturerPointsGet(season, seriesId, raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PointsApi.PointsManufacturerPointsGet: " + e.Message );
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
<a name="pointsownerpointsget"></a>
# **PointsOwnerPointsGet**
> Collection<OwnerPoint> PointsOwnerPointsGet (int? season = null, int? seriesId = null, int? raceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class PointsOwnerPointsGetExample
    {
        public void main()
        {

            var apiInstance = new PointsApi();
            var season = 56;  // int? |  (optional) 
            var seriesId = 56;  // int? |  (optional) 
            var raceId = 56;  // int? |  (optional)  (default to 0)

            try
            {
                Collection&lt;OwnerPoint&gt; result = apiInstance.PointsOwnerPointsGet(season, seriesId, raceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PointsApi.PointsOwnerPointsGet: " + e.Message );
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
