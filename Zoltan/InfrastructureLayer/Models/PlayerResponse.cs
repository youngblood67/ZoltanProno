using Newtonsoft.Json;

namespace InfrastructureLayer.Models
{
    public class PlayerResponse
    {
        [JsonProperty("player")]
        public Player Player { get; set; }

        [JsonProperty("statistics")]
        public List<PlayerStatistics> Statistics { get; set; }

    }
}
