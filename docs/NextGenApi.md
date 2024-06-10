# NASCAR.Data.Client.Api.NextGenApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DataPoints**](NextGenApi.md#datapoints) | **GET** /nextgen-datapoints | 
[**Sources**](NextGenApi.md#sources) | **GET** /nextgen-sources | 

<a name="datapoints"></a>
# **DataPoints**
> Collection<NextGenDatapoint> DataPoints ()



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class DataPointsExample
    {
        public void main()
        {

            var apiInstance = new NextGenApi();

            try
            {
                Collection&lt;NextGenDatapoint&gt; result = apiInstance.DataPoints();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NextGenApi.DataPoints: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Collection<NextGenDatapoint>**](NextGenDatapoint.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="sources"></a>
# **Sources**
> Collection<NextGenSource> Sources ()



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class SourcesExample
    {
        public void main()
        {

            var apiInstance = new NextGenApi();

            try
            {
                Collection&lt;NextGenSource&gt; result = apiInstance.Sources();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NextGenApi.Sources: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Collection<NextGenSource>**](NextGenSource.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
