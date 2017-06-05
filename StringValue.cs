using Newtonsoft.Json;

namespace PokedexNET
{
    public class StringValue
    {

        [JsonProperty("fr")]
        public string Fr { get; set; }

        [JsonProperty("de")]
        public string De { get; set; }

        [JsonProperty("it")]
        public string It { get; set; }

        [JsonProperty("en")]
        public string En { get; set; }
    }
}