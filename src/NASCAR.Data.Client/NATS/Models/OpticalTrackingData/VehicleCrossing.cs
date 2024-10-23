using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASCAR.Data.Client.NATS.Models.OpticalTrackingData
{
    public class VehicleCrossing
    {
        /// <summary>
        /// Gets or sets the lap number at which the vehicle last crossed a loop.
        /// </summary>
        [JsonProperty("lap")]
        public int Lap { get; set; }

        /// <summary>
        /// Gets or sets the name of the loop last crossed.
        /// </summary>
        [JsonProperty("loopName")]
        public string LoopName { get; set; }

        /// <summary>
        /// Gets or sets the NTP time in microseconds at which the vehicle last crossed the loop.
        /// </summary>
        [JsonProperty("time")]
        public long Time { get; set; }
    }
}
