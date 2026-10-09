# NASCAR.Data.Client.Model.RaceViewModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SeriesId** | **int?** | Series identifier | [optional] 
**RaceNumber** | **int?** | Race number within the season/series schedule | [optional] 
**Name** | **string** | Race name | [optional] 
**Promoter** | **string** | Promoter of the race | [optional] 
**Laps** | **int?** | Total number of laps | [optional] 
**Distance** | **double?** | Race distance | [optional] 
**RaceTypeId** | **int?** | Race Type Identifier (1-Race, 2-Duel, 3-Heat, 4-Exhibition) | [optional] 
**TotalRaceTime** | **string** | Total race time formatted as HH:MM:SS | [optional] 
**Date** | **DateTimeOffset?** | Race date | [optional] 
**Comments** | **string** | Race comments | [optional] 
**Cautions** | [**Collection&lt;Caution&gt;**](Caution.md) | Cautions during the race | [optional] 
**Entries** | [**Collection&lt;RunEntry&gt;**](RunEntry.md) | Race entries | [optional] 
**Infractions** | [**Collection&lt;RaceInfraction&gt;**](RaceInfraction.md) | Race infractions | [optional] 
**LapLeaders** | [**Collection&lt;LapLeader&gt;**](LapLeader.md) | Lap leaders | [optional] 
**LoopStats** | [**Collection&lt;LoopStat&gt;**](LoopStat.md) | Loop stats for the race | [optional] 
**Pitstops** | [**Collection&lt;Pitstop&gt;**](Pitstop.md) | Pit stops during the race | [optional] 
**PracticeResults** | [**Collection&lt;PracticeRunResults&gt;**](PracticeRunResults.md) | Practice results | [optional] 
**QualifyingResults** | [**Collection&lt;QualifyingRunResults&gt;**](QualifyingRunResults.md) | Qualifying results | [optional] 
**RaceResults** | [**Collection&lt;RaceRunResults&gt;**](RaceRunResults.md) | Race results | [optional] 
**Runs** | [**Collection&lt;RunDetails&gt;**](RunDetails.md) | Runs associated with the race | [optional] 
**StageResults** | [**Collection&lt;StageRunResults&gt;**](StageRunResults.md) | Stage results | [optional] 
**Schedule** | [**Collection&lt;WeekendSchedule&gt;**](WeekendSchedule.md) | Weekend schedule entries for the race | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

