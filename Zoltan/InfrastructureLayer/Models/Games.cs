using Newtonsoft.Json;

namespace InfrastructureLayer.Models
{
    public class Games
    {
        [JsonProperty("appearences")]
        public int Appearances { get; set; }

        [JsonProperty("lineups")]
        public int Lineups { get; set; }

        [JsonProperty("minutes")]
        public int Minutes { get; set; }

        [JsonProperty("number")]
        public object Number { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("rating")]
        public string Rating { get; set; }

        [JsonProperty("captain")]
        public bool Captain { get; set; }
    }
}