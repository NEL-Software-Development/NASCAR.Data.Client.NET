# NASCAR.Data.Client.Model.RaceDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | The id of the race | [optional] 
**HistoryRaceId** | **int?** | The race id from the history database | [optional] [default to -1]
**SeriesId** | **int?** | The series id of the race | [optional] 
**Name** | **string** | The race name | [optional] 
**Promoter** | **string** | The promoter of the race | [optional] 
**Laps** | **int?** | Laps | [optional] 
**Distance** | **double?** | Race distance | [optional] 
**PracticeResults** | **string** | URL to Practice results | [optional] 
**QualifyingResults** | **string** | URL to Qualifying results | [optional] 
**RaceResults** | **string** | URL to race results | [optional] 
**Cautions** | **string** | URL to race cautions | [optional] 
**Infractions** | **string** | URL to race infractions | [optional] 
**LapLeaders** | **string** | URL to race lap leaders | [optional] 
**Pitstops** | **string** | URL to race pitstops | [optional] 
**Date** | **DateTimeOffset?** | Race date | [optional] 
**Comments** | **string** | Race Comments | [optional] 
**TrackName** | **string** | Track Name | [optional] 
**TrackId** | **int?** | Track Id | [optional] 
**InspectionComplete** | **bool?** | Has inspection been completed | [optional] 
**Entries** | [**Collection&lt;RunEntry&gt;**](RunEntry.md) | Race entries | [optional] 
**Runs** | [**Collection&lt;RunDetails&gt;**](RunDetails.md) | Runs | [optional] 
**Schedule** | [**Collection&lt;WeekendSchedule&gt;**](WeekendSchedule.md) | Weekend Schedule | [optional] 
**FastestLapAward** | [**FastestLapAwards**](FastestLapAwards.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

