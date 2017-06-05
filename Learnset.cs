using Newtonsoft.Json;

namespace PokedexNET
{
    public class Learnset
    {

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("move")]
        public string Move { get; set; }

        [JsonProperty("tm")]
        public string Tm { get; set; }

        [JsonProperty("parent")]
        public string Parent { get; set; }
    }
}