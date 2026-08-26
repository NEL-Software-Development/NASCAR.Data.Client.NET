# NASCAR.Data.Client.Model.RaceWeek
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Unique identifier given and used by the NASCAR Data API | [optional] 
**Season** | **int?** | Race season | [default to 0]
**Venue** | **string** | Venue name for the race week event | [default to ""]
**RunningSeries** | **string** | List of series running at this event | [default to ""]
**StartDate** | **DateTimeOffset?** | Start date of the race week | [optional] 
**EndDate** | **DateTimeOffset?** | End date of the race week | [optional] 
**IsLive** | **bool?** | Indicates whether this race week is currently in progress | [optional] 
**Details** | **string** | URL to race week details | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

