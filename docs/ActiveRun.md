# NASCAR.Data.Client.Model.ActiveRun
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the run | [optional] 
**StartTime** | **DateTimeOffset?** | Scheduled start time | [optional] 
**RunState** | [**RunState**](RunState.md) |  | [optional] 
**RunType** | [**RunType**](RunType.md) |  | [optional] 
**Duration** | **int?** | The scheduled duration of the run in seconds | [optional] 
**FlagState** | **string** | Current flag state (Green, Yellow, Red, Checkered, White, Stop, NoActiveFlag, Warm, Invalid) | [optional] 
**Flags** | [**Collection&lt;Flag&gt;**](Flag.md) | Flags associated with this run | [optional] 
**Entries** | [**Collection&lt;RunEntry&gt;**](RunEntry.md) | Run entries (vehicles and drivers participating in this run) | [optional] 
**Results** | [**Collection&lt;RunResult&gt;**](RunResult.md) | Current results for this run | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

