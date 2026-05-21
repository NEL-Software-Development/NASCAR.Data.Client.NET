# NASCAR.Data.Client.Api.PointsApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PointsDriverPointsGet**](PointsApi.md#pointsdriverpointsget) | **GET** /points/driver-points | Retrieves driver points for a specific race.
[**PointsManufacturerPointsGet**](PointsApi.md#pointsmanufacturerpointsget) | **GET** /points/manufacturer-points | Retrieves manufacturer points for a specific season, series, and optionally a specific race.
[**PointsOwnerPointsGet**](PointsApi.md#pointsownerpointsget) | **GET** /points/owner-points | Retrieves owner points for a specific season, series, and optionally a specific race.

<a name="pointsdriverpointsget"></a>
# **PointsDriverPointsGet**
> Collection<DriverPointsView> PointsDriverPointsGet (int? raceId = null)

Retrieves driver points for a specific race.

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
            var raceId = 56;  // int? | Unique race identifier. If not provided, points for the most recent races will be returned. (optional) 

            try
            {
                // Retrieves driver points for a specific race.
                Collection&lt;DriverPointsView&gt; result = apiInstance.PointsDriverPointsGet(raceId);
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
 **raceId** | **int?**| Unique race identifier. If not provided, points for the most recent races will be returned. | [optional] 

### Return type

[**Collection<DriverPointsView>**](DriverPointsView.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="pointsmanufacturerpointsget"></a>
# **PointsManufacturerPointsGet**
> Collection<ManufacturerPoint> PointsManufacturerPointsGet (int? season = null, int? seriesId = null, int? raceId = null)

Retrieves manufacturer points for a specific season, series, and optionally a specific race.

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
            var season = 56;  // int? | Four-digit season year to query. (optional) 
            var seriesId = 56;  // int? | Series identifier. Common values are 1 for Cup, 2 for O'Reilly, and 3 for Truck. (optional) 
            var raceId = 56;  // int? | Unique race identifier. If specified, the points will be limited to the given race. If not provided or set to 0, points for all races in the specified season and series will be returned. (optional)  (default to 0)

            try
            {
                // Retrieves manufacturer points for a specific season, series, and optionally a specific race.
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
 **season** | **int?**| Four-digit season year to query. | [optional] 
 **seriesId** | **int?**| Series identifier. Common values are 1 for Cup, 2 for O&#x27;Reilly, and 3 for Truck. | [optional] 
 **raceId** | **int?**| Unique race identifier. If specified, the points will be limited to the given race. If not provided or set to 0, points for all races in the specified season and series will be returned. | [optional] [default to 0]

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
> Collection<OwnerPointsView> PointsOwnerPointsGet (int? raceId = null)

Retrieves owner points for a specific season, series, and optionally a specific race.

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
            var raceId = 56;  // int? | Unique race identifier. If specified, the points will be limited to the given race. If not provided or set to 0, points for all races in the specified season and series will be returned. (optional) 

            try
            {
                // Retrieves owner points for a specific season, series, and optionally a specific race.
                Collection&lt;OwnerPointsView&gt; result = apiInstance.PointsOwnerPointsGet(raceId);
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
 **raceId** | **int?**| Unique race identifier. If specified, the points will be limited to the given race. If not provided or set to 0, points for all races in the specified season and series will be returned. | [optional] 

### Return type

[**Collection<OwnerPointsView>**](OwnerPointsView.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
