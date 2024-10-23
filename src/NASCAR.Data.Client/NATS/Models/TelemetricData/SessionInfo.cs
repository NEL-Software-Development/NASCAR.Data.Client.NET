using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASCAR.Data.Client.NATS.Models.TelemetricData
{
    public class SessionInfo
    {
        /// <summary>
        /// Gets or sets the integer ID assigned from the NASCAR T&S API.
        /// May be null when there is no active run.
        /// </summary>
        [JsonProperty("race_id")]
        public long? RaceId { get; set; }

        /// <summary>
        /// Gets or sets the integer ID series: 1 = Cup, 2 = NXS, 3 = Trucks.
        /// May be null when there is no active run.
        /// </summary>
        [JsonProperty("series_id")]
        public int? SeriesId { get; set; }

        /// <summary>
        /// Gets or sets the integer ID assigned from the NASCAR T&S API.
        /// -1 when there is no active run.
        /// </summary>
        [JsonProperty("run_id")]
        public int RunId { get; set; }

        /// <summary>
        /// Gets or sets the integer ID run type: 1 = Practice, 2 = Qualifying, 3 = Race.
        /// May be null when there is no active run.
        /// </summary>
        [JsonProperty("run_type")]
        public int? RunType { get; set; }
    }
}
