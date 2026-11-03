# NASCAR.Data.Client.Api.InspectionsApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InspectionsAimIdGet**](InspectionsApi.md#inspectionsaimidget) | **GET** /inspections/aim/{id} | For use by the AIM system
[**InspectionsDeviceNumbersGet**](InspectionsApi.md#inspectionsdevicenumbersget) | **GET** /inspections/device-numbers | For use by the MLS system
[**InspectionsIdrGet**](InspectionsApi.md#inspectionsidrget) | **GET** /inspections/idr | For use by the AIM system
[**InspectionsOssGet**](InspectionsApi.md#inspectionsossget) | **GET** /inspections/oss | Retrieves a list of OSS scans for a specific race.
[**InspectionsSubmissionsTechniqueGet**](InspectionsApi.md#inspectionssubmissionstechniqueget) | **GET** /inspections/submissions/technique | For use by Technique chassis builders to track submissions
[**InspectionsVehicleWeightsGet**](InspectionsApi.md#inspectionsvehicleweightsget) | **GET** /inspections/vehicle-weights | Retrieves a list of vehicle weights for a specific race.

<a name="inspectionsaimidget"></a>
# **InspectionsAimIdGet**
> void InspectionsAimIdGet (string id)

For use by the AIM system

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class InspectionsAimIdGetExample
    {
        public void main()
        {

            var apiInstance = new InspectionsApi();
            var id = id_example;  // string | 

            try
            {
                // For use by the AIM system
                apiInstance.InspectionsAimIdGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InspectionsApi.InspectionsAimIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="inspectionsdevicenumbersget"></a>
# **InspectionsDeviceNumbersGet**
> Collection<InspectionResult> InspectionsDeviceNumbersGet ()

For use by the MLS system

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class InspectionsDeviceNumbersGetExample
    {
        public void main()
        {

            var apiInstance = new InspectionsApi();

            try
            {
                // For use by the MLS system
                Collection&lt;InspectionResult&gt; result = apiInstance.InspectionsDeviceNumbersGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InspectionsApi.InspectionsDeviceNumbersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Collection<InspectionResult>**](InspectionResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="inspectionsidrget"></a>
# **InspectionsIdrGet**
> Collection<InspectionResult> InspectionsIdrGet (int? idrNumber = null)

For use by the AIM system

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class InspectionsIdrGetExample
    {
        public void main()
        {

            var apiInstance = new InspectionsApi();
            var idrNumber = 56;  // int? | IDR number. (optional) 

            try
            {
                // For use by the AIM system
                Collection&lt;InspectionResult&gt; result = apiInstance.InspectionsIdrGet(idrNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InspectionsApi.InspectionsIdrGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idrNumber** | **int?**| IDR number. | [optional] 

### Return type

[**Collection<InspectionResult>**](InspectionResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
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
<a name="inspectionssubmissionstechniqueget"></a>
# **InspectionsSubmissionsTechniqueGet**
> Collection<RepairSubmission> InspectionsSubmissionsTechniqueGet ()

For use by Technique chassis builders to track submissions

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class InspectionsSubmissionsTechniqueGetExample
    {
        public void main()
        {

            var apiInstance = new InspectionsApi();

            try
            {
                // For use by Technique chassis builders to track submissions
                Collection&lt;RepairSubmission&gt; result = apiInstance.InspectionsSubmissionsTechniqueGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InspectionsApi.InspectionsSubmissionsTechniqueGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Collection<RepairSubmission>**](RepairSubmission.md)

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
