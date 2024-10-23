using Newtonsoft.Json;
using System.Collections.Generic;

namespace NASCAR.Data.Client.NATS.Models.OpticalTrackingData
{
    public class LocationData
    {
        /// <summary>
        /// Gets or sets the type of data being published.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the source of the data. Will always be otd.
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets the session information associated with the current active run.
        /// </summary>
        [JsonProperty("sessionInfo")]
        public SessionInfo SessionInfo { get; set; }

        /// <summary>
        /// Gets or sets the current state of the race as defined by NASCAR.
        /// </summary>
        [JsonProperty("flagState")]
        public int FlagState { get; set; }

        /// <summary>
        /// Gets or sets the lap that the lead car is on.
        /// </summary>
        [JsonProperty("leadLap")]
        public int LeadLap { get; set; }

        /// <summary>
        /// Gets or sets the NTP time in microseconds showing when the data frame was sent to the message broker.
        /// </summary>
        [JsonProperty("publishedTime")]
        public long PublishedTime { get; set; }

        /// <summary>
        /// Gets or sets the data-point index.
        /// </summary>
        [JsonProperty("sequenceId")]
        public long SequenceId { get; set; }

        /// <summary>
        /// Gets or sets the NTP time in microseconds showing the time which the data corresponds to.
        /// </summary>
        [JsonProperty("time")]
        public long Time { get; set; }

        /// <summary>
        /// Gets or sets the vehicle last crossings information.
        /// </summary>
        [JsonProperty("vehicleLastCrossings")]
        public Dictionary<string, VehicleCrossing> VehicleLastCrossings { get; set; }

        /// <summary>
        /// Gets or sets the array of vehicles' information.
        /// </summary>
        [JsonProperty("vehicles")]
        public List<Vehicle> Vehicles { get; set; }
    }
}
