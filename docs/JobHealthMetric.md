# NASCAR.Data.Client.Model.JobHealthMetric
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**JobId** | **string** |  | [optional] 
**Category** | **string** |  | [optional] 
**CronExpression** | **string** |  | [optional] 
**ExpectedIntervalSeconds** | **int?** |  | [optional] 
**LastRunUtc** | **DateTimeOffset?** |  | [optional] 
**SecondsSinceLastRun** | **double?** |  | [optional] 
**LastStatus** | **string** |  | [optional] 
**LastError** | **string** |  | [optional] 
**IsStale** | **bool?** | True when the gap since the last run exceeds the expected interval by more than the configured threshold. | [optional] 
**TimeSeries** | [**Collection&lt;JobMetricPointDto&gt;**](JobMetricPointDto.md) | One point per persisted minute-bucket within the requested window, ordered oldest to newest. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

