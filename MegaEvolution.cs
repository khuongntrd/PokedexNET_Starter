using System.Collections.Generic;
using Newtonsoft.Json;

namespace PokedexNET
{
    public class MegaEvolution
    {

        [JsonProperty("types")]
        public IList<string> Types { get; set; }

        [JsonProperty("ability")]
        public string Ability { get; set; }

        [JsonProperty("mega_stone")]
        public string MegaStone { get; set; }

        [JsonProperty("height_us")]
        public string HeightUs { get; set; }

        [JsonProperty("height_eu")]
        public string HeightEu { get; set; }

        [JsonProperty("weight_us")]
        public string WeightUs { get; set; }

        [JsonProperty("weight_eu")]
        public string WeightEu { get; set; }

        [JsonProperty("base_stats")]
        public BaseStats BaseStats { get; set; }
    }
}