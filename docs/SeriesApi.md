# NASCAR.Data.Client.Api.SeriesApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SeriesGet**](SeriesApi.md#seriesget) | **GET** /series | Retrieves a list of all racing series, including their unique identifiers and names.
[**SeriesSeasonGet**](SeriesApi.md#seriesseasonget) | **GET** /series/season | 

<a name="seriesget"></a>
# **SeriesGet**
> Collection<Series> SeriesGet ()

Retrieves a list of all racing series, including their unique identifiers and names.

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class SeriesGetExample
    {
        public void main()
        {

            var apiInstance = new SeriesApi();

            try
            {
                // Retrieves a list of all racing series, including their unique identifiers and names.
                Collection&lt;Series&gt; result = apiInstance.SeriesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SeriesApi.SeriesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Collection<Series>**](Series.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="seriesseasonget"></a>
# **SeriesSeasonGet**
> Collection<SeasonSeries> SeriesSeasonGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class SeriesSeasonGetExample
    {
        public void main()
        {

            var apiInstance = new SeriesApi();

            try
            {
                Collection&lt;SeasonSeries&gt; result = apiInstance.SeriesSeasonGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SeriesApi.SeriesSeasonGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Collection<SeasonSeries>**](SeasonSeries.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
