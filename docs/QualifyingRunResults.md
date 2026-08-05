# NASCAR.Data.Client.Model.QualifyingRunResults
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RunName** | **string** | Run name | [optional] 
**RunState** | **string** | Run state:  (Inactive, Active, Completed) | [optional] 
**FlagState** | **string** | Flag state:  (Green, Yellow, Red, Checkered, White, Stop, NoActiveFlag, Warm, Invalid) | [optional] 
**Round** | **int?** | Qualifying round: 0-3 | [optional] 
**Group** | **string** | Qualifying group: A, B, (empty) | [optional] 
**TimeLimit** | **int?** | Time limit (in seconds) for the round | [optional] 
**Results** | [**Collection&lt;RunResult&gt;**](RunResult.md) | Qualifying results | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

