using Newtonsoft.Json;

namespace PokedexNET
{
    public class Ability
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("hidden")]
        public bool? Hidden { get; set; }
    }
}