using Newtonsoft.Json;

namespace InfrastructureLayer.Models
{
    public class Query
    {
        [JsonProperty("response")]
        public List<Response> Response { get; set; }

    }
}
