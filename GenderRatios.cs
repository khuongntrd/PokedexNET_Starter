using Newtonsoft.Json;

namespace PokedexNET
{
    public class GenderRatios
    {

        [JsonProperty("male")]
        public double Male { get; set; }

        [JsonProperty("female")]
        public double Female { get; set; }
    }
}