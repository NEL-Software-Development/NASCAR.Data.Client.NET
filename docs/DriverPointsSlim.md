# NASCAR.Data.Client.Model.DriverPointsSlim
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PointsPosition** | **int?** | Overall points rank for season | [optional] 
**DriverId** | **int?** | Unique NASCAR ID given for each driver | [optional] 
**Driver** | **string** | Driver full name | [optional] 
**DriverAbbrev** | **string** | Abbreviated driver name | [optional] 
**CarNumber** | **string** | Corresponding car number for this driver during this run | [optional] 
**RacePos** | **int?** | Position of vehicle in current run | [optional] 
**Stage1Position** | **int?** | Finish position of vehicle for stage 1 | [optional] 
**Stage1Points** | **int?** | Stage points earned for vehicle for stage 1 | [optional] 
**Stage2Position** | **int?** | Finish position of vehicle for stage 2 | [optional] 
**Stage2Points** | **int?** | Stage points earned for vehicle for stage 2 | [optional] 
**Stage3Position** | **int?** | Finish position of vehicle for stage 3 | [optional] 
**Stage3Points** | **int?** | Stage points earned for vehicle for stage 3 | [optional] 
**FinishPoints** | **int?** | Number of points earned based on finish position for this race | [optional] 
**RacePoints** | **int?** | Number of total points earned based on finish position and stage points for this race | [optional] 
**Points** | **int?** | Total regular season points | [optional] 
**DeltaLeader** | **int?** | Number of points behind the leader | [optional] 
**DeltaNext** | **int?** | Number of points behind the next driver | [optional] 
**InRound** | **bool?** | Is this driver in the current round (true or false) | [optional] 
**IsPointsEligible** | **bool?** | Is driver points eligible for the series (true or false) | [optional] 
**IsPostEntry** | **bool?** | Is the driver a post-entry for this race | [optional] 
**IsCutline** | **bool?** | Cut line below this driver, true for only one record | [optional] 
**IsLocked** | **bool?** | Locked into the next round | [optional] 
**IsRoundEligible** | **bool?** | Is eligible for the current round | [optional] 
**TvSortOrder** | **int?** | The order displayed on TV (locked drivers sorted by wins desc, then current leader, then all else sorted by total points) | [optional] 
**RoundRaceWins** | **int?** | Wins in current round (round 0, etc.) | [optional] 
**CutlinePointsDelta** | **int?** | Difference to cutline adjacent driver (last driver locked below, and first driver out above) | [optional] 
**StageWins** | **int?** | Stage wins for current season | [optional] 
**Poles** | **int?** | Number of poles for current season | [optional] 
**Attempts** | **int?** | Number of attempts to qualify for current season | [optional] 
**Wins** | **int?** | Number of wins for current season | [optional] 
**Top5** | **int?** | Number of top 5 finishes for current season | [optional] 
**Top10** | **int?** | Number of top 10 finishes for current season | [optional] 
**IsFastestLapPoint** | **bool?** | True if driver earned a point for fastest lap point | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

