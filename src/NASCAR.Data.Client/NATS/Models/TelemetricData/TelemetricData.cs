using Newtonsoft.Json;

namespace NASCAR.Data.Client.NATS.Models.TelemetricData
{
    public class TelemetricData
    {
        /// <summary>
        /// Gets or sets the datapoint ID.
        /// </summary>
        [JsonProperty("datapoint_id")]
        public string DataPointId { get; set; }

        /// <summary>
        /// Gets or sets the friendly description of the datapoint.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the session information associated with the datapoint.
        /// </summary>
        [JsonProperty("sessionInfo")]
        public SessionInfo SessionInfo { get; set; }

        /// <summary>
        /// Gets or sets the source of the data (e.g., ECU or Pitroad).
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets the NTP time in microseconds since UNIX epoch in UTC,
        /// showing the time at which the data frame was collected from the vehicle.
        /// </summary>
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        /// <summary>
        /// Gets or sets the type of data received.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the decoded and scaled field value.
        /// </summary>
        [JsonProperty("value")]
        public double Value { get; set; }

        /// <summary>
        /// Gets or sets the car ID (Team Vehicle Number).
        /// </summary>
        [JsonProperty("vehicle_id")]
        public string VehicleId { get; set; }
    }
}
