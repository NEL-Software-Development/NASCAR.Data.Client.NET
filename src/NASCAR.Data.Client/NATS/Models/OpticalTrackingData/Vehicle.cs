using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASCAR.Data.Client.NATS.Models.OpticalTrackingData
{
    public class Vehicle
    {
        /// <summary>
        /// Gets or sets the position of the vehicle in meters.
        /// </summary>
        [JsonProperty("position")]
        public List<double> Position { get; set; }

        /// <summary>
        /// Gets or sets the vehicle speed in miles per hour.
        /// </summary>
        [JsonProperty("mph")]
        public double Mph { get; set; }

        /// <summary>
        /// Gets or sets the unit quaternion representing the rotation in 3D.
        /// </summary>
        [JsonProperty("quaternion")]
        public List<double> Quaternion { get; set; }

        /// <summary>
        /// Gets or sets the internal information for Bolt.
        /// </summary>
        [JsonProperty("trackId")]
        public int TrackId { get; set; }

        /// <summary>
        /// Gets or sets the car number.
        /// </summary>
        [JsonProperty("vehicleId")]
        public string VehicleId { get; set; }

        /// <summary>
        /// Gets or sets the vehicle velocity in meters per second.
        /// </summary>
        [JsonProperty("velocity")]
        public List<double> Velocity { get; set; }

        /// <summary>
        /// Gets or sets the direction the vehicle is facing on the track.
        /// </summary>
        [JsonProperty("heading")]
        public double Heading { get; set; }

        /// <summary>
        /// Gets or sets the completeness of the data for the vehicle over the last 60 seconds.
        /// </summary>
        [JsonProperty("recentCompleteness")]
        public double RecentCompleteness { get; set; }

        /// <summary>
        /// Gets or sets the fractional position of the vehicle around the track.
        /// </summary>
        [JsonProperty("lapFraction")]
        public double LapFraction { get; set; }
    }
}
