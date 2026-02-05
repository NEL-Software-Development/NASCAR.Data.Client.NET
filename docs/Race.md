# NASCAR.Data.Client.Model.Race
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Unique identifier given and used by the NASCAR Data API | [optional] 
**PrincipalRaceId** | **int?** | The principal race id of the race | [optional] 
**HistoryRaceId** | **int?** | The race id from the history database | [optional] [default to -1]
**RaceweekId** | **int?** | The race | [optional] 
**SeriesId** | **int?** | The series id of the race | [optional] 
**Name** | **string** | The race name | [optional] 
**Promoter** | **string** | The promoter of the race | [optional] 
**Laps** | **int?** | Laps | [optional] 
**Distance** | **double?** | Race distance | [optional] 
**InspectionComplete** | **bool?** | Has inspection been completed | [optional] 
**PracticeResults** | **string** | URL to practice results | [optional] 
**QualifyingResults** | **string** | URL to Qualifying results | [optional] 
**RaceResults** | **string** | URL to race results | [optional] 
**Cautions** | **string** | URL to race cautions | [optional] 
**Infractions** | **string** | URL to race infractions | [optional] 
**LapLeaders** | **string** | URL to race lap leaders | [optional] 
**Pitstops** | **string** | URL to race pitstops | [optional] 
**Stages** | **string** | URL to race stages | [optional] 
**Date** | **DateTimeOffset?** | Race date | [optional] 
**Comments** | **string** | Race comments | [optional] 
**HistoryTrackId** | **int?** | History Track Id | [optional] 
**TrackId** | **int?** | Track Id | [optional] 
**FastestLapAward** | [**FastestLapAwards**](FastestLapAwards.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

