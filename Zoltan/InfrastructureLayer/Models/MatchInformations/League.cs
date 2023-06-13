using Newtonsoft.Json;

namespace InfrastructureLayer.Models.MatchInformations
{
    public class League
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("season")]
        public string Season { get; set; }

        [JsonProperty("round")]
        public string Round { get; set; }
    }
}