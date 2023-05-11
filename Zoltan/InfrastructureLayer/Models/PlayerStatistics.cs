using Newtonsoft.Json;

namespace InfrastructureLayer.Models
{
    public class PlayerStatistics
    {

        [JsonProperty("games")]
        public Games Games { get; set; }

        [JsonProperty("substitutes")]
        public Substitutes Substitutes { get; set; }

        [JsonProperty("shots")]
        public Shots Shots { get; set; }

        [JsonProperty("goals")]
        public Goals Goals { get; set; }

        [JsonProperty("passes")]
        public Passes Passes { get; set; }

        [JsonProperty("tackles")]
        public Tackles Tackles { get; set; }

        [JsonProperty("duels")]
        public Duels Duels { get; set; }

        [JsonProperty("dribbles")]
        public Dribbles Dribbles { get; set; }

        [JsonProperty("fouls")]
        public Fouls Fouls { get; set; }

        [JsonProperty("cards")]
        public Cards Cards { get; set; }

        [JsonProperty("penalty")]
        public Penalty Penalty { get; set; }
    }
}
