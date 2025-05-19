# NASCAR.Data.Client.Api.VendorApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**VendorCrlTestresultPost**](VendorApi.md#vendorcrltestresultpost) | **POST** /vendor/crl_testresult | 
[**VendorTiresPost**](VendorApi.md#vendortirespost) | **POST** /vendor/tires | 
[**VendorUtmOffsetsPost**](VendorApi.md#vendorutmoffsetspost) | **POST** /vendor/utm_offsets | 

<a name="vendorcrltestresultpost"></a>
# **VendorCrlTestresultPost**
> void VendorCrlTestresultPost (CrlFormFoxResult body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class VendorCrlTestresultPostExample
    {
        public void main()
        {

            var apiInstance = new VendorApi();
            var body = new CrlFormFoxResult(); // CrlFormFoxResult |  (optional) 

            try
            {
                apiInstance.VendorCrlTestresultPost(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorApi.VendorCrlTestresultPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CrlFormFoxResult**](CrlFormFoxResult.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="vendortirespost"></a>
# **VendorTiresPost**
> TireListETLSaveResult VendorTiresPost (Collection<Tire> body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class VendorTiresPostExample
    {
        public void main()
        {

            var apiInstance = new VendorApi();
            var body = new Collection<Tire>(); // Collection<Tire> |  (optional) 

            try
            {
                TireListETLSaveResult result = apiInstance.VendorTiresPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorApi.VendorTiresPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Collection&lt;Tire&gt;**](Tire.md)|  | [optional] 

### Return type

[**TireListETLSaveResult**](TireListETLSaveResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="vendorutmoffsetspost"></a>
# **VendorUtmOffsetsPost**
> OpticalTrackingUTMOffsetListETLSaveResult VendorUtmOffsetsPost (Collection<OpticalTrackingUTMOffset> body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class VendorUtmOffsetsPostExample
    {
        public void main()
        {

            var apiInstance = new VendorApi();
            var body = new Collection<OpticalTrackingUTMOffset>(); // Collection<OpticalTrackingUTMOffset> |  (optional) 

            try
            {
                OpticalTrackingUTMOffsetListETLSaveResult result = apiInstance.VendorUtmOffsetsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VendorApi.VendorUtmOffsetsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Collection&lt;OpticalTrackingUTMOffset&gt;**](OpticalTrackingUTMOffset.md)|  | [optional] 

### Return type

[**OpticalTrackingUTMOffsetListETLSaveResult**](OpticalTrackingUTMOffsetListETLSaveResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
