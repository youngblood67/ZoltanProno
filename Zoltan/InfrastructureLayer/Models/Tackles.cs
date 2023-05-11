using Newtonsoft.Json;

namespace InfrastructureLayer.Models
{
    public class Tackles
    {
        [JsonProperty("total")]
        public int? Total { get; set; }

        [JsonProperty("blocks")]
        public int? Blocks { get; set; }

        [JsonProperty("interceptions")]
        public int? Interceptions { get; set; }

    }
}