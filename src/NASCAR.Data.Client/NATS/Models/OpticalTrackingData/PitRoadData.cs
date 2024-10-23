using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASCAR.Data.Client.NATS.Models.OpticalTrackingData
{
    public class PitRoadData
    {
        /// <summary>
        /// Gets or sets the internal information for Bolt.
        /// </summary>
        [JsonProperty("apgTime")]
        public long ApgTime { get; set; }

        /// <summary>
        /// Gets or sets the time at which the car starts to leave the pit box.
        /// May be null. Obtained from optical tracking.
        /// </summary>
        [JsonProperty("boxLeaveTime")]
        public long? BoxLeaveTime { get; set; }

        /// <summary>
        /// Gets or sets the time at which the car stopped in the pit box.
        /// May be null. Obtained from optical tracking.
        /// </summary>
        [JsonProperty("boxStopTime")]
        public long? BoxStopTime { get; set; }

        /// <summary>
        /// Gets or sets the duration from car stopped until first side is jacked up.
        /// </summary>
        [JsonProperty("carStopToJack")]
        public long CarStopToJack { get; set; }

        /// <summary>
        /// Gets or sets the duration from car stopped until final side jack down.
        /// </summary>
        [JsonProperty("crewTime")]
        public long CrewTime { get; set; }

        /// <summary>
        /// Gets or sets the ID of the datapoint being published to the platform.
        /// </summary>
        [JsonProperty("datapoint_id")]
        public string DatapointId { get; set; }

        /// <summary>
        /// Gets or sets the total duration in pit lane minus duration when car is stopped.
        /// </summary>
        [JsonProperty("driverTime")]
        public long DriverTime { get; set; }

        /// <summary>
        /// Gets or sets the type of event.
        /// One of: CAR_ENTERS_PIT_ROAD, CAR_STOPS_IN_BOX, CAR_LEAVING_BOX, CAR_LEAVES_PIT_ROAD.
        /// </summary>
        [JsonProperty("event")]
        public string Event { get; set; }

        /// <summary>
        /// Gets or sets the duration in microseconds from the car passing the pit in loop to stopping in the pit box.
        /// May be null.
        /// </summary>
        [JsonProperty("inTravelDuration")]
        public long? InTravelDuration { get; set; }

        /// <summary>
        /// Gets or sets the duration from first side jack down to second side jack up.
        /// </summary>
        [JsonProperty("jackTime")]
        public long JackTime { get; set; }

        /// <summary>
        /// Gets or sets the duration from final car jack down until car starts moving.
        /// </summary>
        [JsonProperty("jackToCarGoes")]
        public long JackToCarGoes { get; set; }

        /// <summary>
        /// Gets or sets the current lap of the car in this event.
        /// </summary>
        [JsonProperty("lapCount")]
        public int LapCount { get; set; }

        /// <summary>
        /// Gets or sets the lap that the lead car is on.
        /// </summary>
        [JsonProperty("leadLap")]
        public int LeadLap { get; set; }

        /// <summary>
        /// Gets or sets the duration of the left side jacked up.
        /// </summary>
        [JsonProperty("leftTime")]
        public long LeftTime { get; set; }

        /// <summary>
        /// Gets or sets the duration in microseconds from the car leaving the pit box to passing the pit out loop.
        /// May be null.
        /// </summary>
        [JsonProperty("outTravelDuration")]
        public long? OutTravelDuration { get; set; }

        /// <summary>
        /// Gets or sets the flag state when the car passed the pit in loop (enters pit road).
        /// Taken from timing loop crossing messages.
        /// </summary>
        [JsonProperty("pitInFlagStatus")]
        public int PitInFlagStatus { get; set; }

        /// <summary>
        /// Gets or sets the time that the car passed the pit in loop (enters pit road).
        /// Obtained from timing loop crossing messages.
        /// </summary>
        [JsonProperty("pitInTime")]
        public long PitInTime { get; set; }

        /// <summary>
        /// Gets or sets the flag state when the car passed the pit out loop (exited pit road).
        /// May be null. Taken from timing loop crossing messages.
        /// </summary>
        [JsonProperty("pitOutFlagStatus")]
        public int? PitOutFlagStatus { get; set; }

        /// <summary>
        /// Gets or sets the time that the car passed the pit out loop (exited pit road).
        /// Obtained from timing loop crossing messages.
        /// </summary>
        [JsonProperty("pitOutTime")]
        public long PitOutTime { get; set; }

        /// <summary>
        /// Gets or sets the pit stop duration in microseconds.
        /// May be null.
        /// </summary>
        [JsonProperty("pitStopDuration")]
        public long? PitStopDuration { get; set; }

        /// <summary>
        /// Gets or sets the duration in microseconds from the car passing the pit in loop to passing the pit out loop.
        /// May be null.
        /// </summary>
        [JsonProperty("pitTotalDuration")]
        public long? PitTotalDuration { get; set; }

        /// <summary>
        /// Gets or sets the time at which the data frame was sent to the message broker.
        /// </summary>
        [JsonProperty("publishTime")]
        public long PublishTime { get; set; }

        /// <summary>
        /// Gets or sets the duration of the right side jacked up.
        /// </summary>
        [JsonProperty("rightTime")]
        public long RightTime { get; set; }

        /// <summary>
        /// Gets or sets the session information associated with the current active run.
        /// </summary>
        [JsonProperty("sessionInfo")]
        public SessionInfo SessionInfo { get; set; }

        /// <summary>
        /// Gets or sets the time for which the current event was processed.
        /// </summary>
        [JsonProperty("time")]
        public long Time { get; set; }

        /// <summary>
        /// Gets or sets the number of tires changed.
        /// </summary>
        [JsonProperty("tires")]
        public int Tires { get; set; }

        /// <summary>
        /// Gets or sets the type of data being published.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the car number.
        /// </summary>
        [JsonProperty("vehicleId")]
        public string VehicleId { get; set; }
    }
}
