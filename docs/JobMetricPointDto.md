# NASCAR.Data.Client.Model.JobMetricPointDto
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BucketStartUtc** | **DateTimeOffset?** |  | [optional] 
**RunCount** | **int?** |  | [optional] 
**FailureCount** | **int?** |  | [optional] 
**AverageLatencyMs** | **double?** |  | [optional] 
**MinLatencyMs** | **double?** |  | [optional] 
**MaxLatencyMs** | **double?** |  | [optional] 
**AverageIntervalSeconds** | **double?** | Actual average time between runs during this bucket, in seconds. | [optional] 
**ExpectedIntervalSeconds** | **int?** | Expected interval in seconds, derived from the job&#x27;s registered cron expression as of this bucket. | [optional] 
**IntervalDriftPercent** | **double?** | Percent drift of AverageIntervalSeconds from ExpectedIntervalSeconds for this  bucket. Positive means the job ran less often than scheduled (falling behind);  negative means more often. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

