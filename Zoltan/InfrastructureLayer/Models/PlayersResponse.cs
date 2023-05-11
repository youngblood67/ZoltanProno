using Newtonsoft.Json;

namespace InfrastructureLayer.Models
{
    public class PlayersResponse
    {
        [JsonProperty("get")]
        public string Get { get; set; }

        [JsonProperty("parameters")]
        public Dictionary<string, string> Parameters { get; set; }

        [JsonProperty("errors")]
        public List<object> Errors { get; set; }

        [JsonProperty("results")]
        public int Results { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }

        [JsonProperty("response")]
        public List<PlayerResponse> Players { get; set; }

    }
}
