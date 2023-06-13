using Newtonsoft.Json;

namespace InfrastructureLayer.Models.MatchInformations
{
    public class Response
    {
        [JsonProperty("league")]
        public League League { get; set; }

        [JsonProperty("teams")]
        public Teams Teams { get; set; }

        [JsonProperty("goals")]
        public Goals Goals { get; set; }

        [JsonProperty("score")]
        public Score Score { get; set; }
    }
}
