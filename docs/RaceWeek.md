# NASCAR.Data.Client.Model.RaceWeek
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Unique identifier given and used by the NASCAR Data API | [optional] 
**Season** | **int?** | Race season | [default to 0]
**Venue** | **string** | Venue | [default to ""]
**RunningSeries** | **string** | List of series running at this event | [default to ""]
**StartDate** | **DateTimeOffset?** | Start of raceweek | [optional] 
**EndDate** | **DateTimeOffset?** | End of raceweek | [optional] 
**IsLive** | **bool?** | Is this raceweek currently in progress | [optional] 
**Details** | **string** | URL to raceweek details | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

