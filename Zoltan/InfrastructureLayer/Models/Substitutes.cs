using Newtonsoft.Json;

namespace InfrastructureLayer.Models
{
    public class Substitutes
    {
        [JsonProperty("in")]
        public int In { get; set; }

        [JsonProperty("out")]
        public int Out { get; set; }

        [JsonProperty("bench")]
        public int Bench { get; set; }
    }
}