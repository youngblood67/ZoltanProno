using Newtonsoft.Json;

namespace InfrastructureLayer.Models
{
    public class Duels
    {
        [JsonProperty("total")]
        public int? Total { get; set; }

        [JsonProperty("won")]
        public int? Won { get; set; }

    }
}