# NASCAR.Data.Client.Model.Result
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Unique identifier given and used by the NASCAR Data API | [optional] 
**EntryId** | **int?** | Associated entry identifier | [optional] 
**FinishPosition** | **int?** | Finish position | [optional] 
**DriverName** | **string** | Driver name | [optional] 
**VehicleNumber** | **string** | Vehicle number | [optional] 
**Laps** | **int?** | Total number of laps | [optional] 
**StartPosition** | **int?** | Start position | [optional] 
**PitBox** | **int?** | Pit box assigned to the vehicle | [optional] 
**BestTime** | **int?** | Best lap time in milliseconds | [optional] 
**BestSpeed** | **double?** | Best speed in MPH | [optional] 
**BestLap** | **int?** | Best lap number | [optional] 
**LastLapTime** | **int?** | Last lap time in milliseconds | [optional] 
**DeltaNextTime** | **int?** | Number of milliseconds behind the next position | [optional] 
**DeltaNextLaps** | **int?** | Number of laps behind the next position | [optional] 
**DeltaLeaderTime** | **int?** | Number of milliseconds behind the leader | [optional] 
**DeltaLeaderLaps** | **int?** | Number of laps behind the leader | [optional] 
**OnTrack** | **bool?** | Indicates whether the vehicle is currently on track | [optional] 
**IsOnDvp** | **bool?** | Indicates whether the vehicle is currently on the DVP clock | [optional] 
**Status** | **string** | Vehicle Status (0&#x3D;None, 1&#x3D;Active, 2&#x3D;DNS, 3&#x3D;DNF, 4&#x3D;DQ, 5&#x3D;Pace Car, 6&#x3D;Garage | [optional] 
**Comment** | **string** | Comment associated with the result | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

