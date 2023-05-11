using Newtonsoft.Json;

namespace InfrastructureLayer.Models
{
    public class Paging
    {
        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }
}