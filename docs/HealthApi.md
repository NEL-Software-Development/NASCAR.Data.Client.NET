# NASCAR.Data.Client.Api.HealthApi

All URIs are relative to */api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HealthJobsGet**](HealthApi.md#healthjobsget) | **GET** /health/jobs | Returns time-series run metrics for every registered recurring ETL job: fixed  fields (current status, cron, staleness) appear once per job, with a TimeSeries  array of per-minute buckets within the requested window for plotting cadence,  latency, and drift trends over time.

<a name="healthjobsget"></a>
# **HealthJobsGet**
> Collection<JobHealthMetric> HealthJobsGet (int? windowMinutes = null)

Returns time-series run metrics for every registered recurring ETL job: fixed  fields (current status, cron, staleness) appear once per job, with a TimeSeries  array of per-minute buckets within the requested window for plotting cadence,  latency, and drift trends over time.

### Example
```csharp
using System;
using System.Diagnostics;
using NASCAR.Data.Client.Api;
using NASCAR.Data.Client.Client;
using NASCAR.Data.Client.Model;

namespace Example
{
    public class HealthJobsGetExample
    {
        public void main()
        {

            var apiInstance = new HealthApi();
            var windowMinutes = 56;  // int? | How far back to return time-series buckets. Defaults to 60 minutes. (optional)  (default to 60)

            try
            {
                // Returns time-series run metrics for every registered recurring ETL job: fixed  fields (current status, cron, staleness) appear once per job, with a TimeSeries  array of per-minute buckets within the requested window for plotting cadence,  latency, and drift trends over time.
                Collection&lt;JobHealthMetric&gt; result = apiInstance.HealthJobsGet(windowMinutes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthApi.HealthJobsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **windowMinutes** | **int?**| How far back to return time-series buckets. Defaults to 60 minutes. | [optional] [default to 60]

### Return type

[**Collection<JobHealthMetric>**](JobHealthMetric.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
