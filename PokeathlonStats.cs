using System.Collections.Generic;
using Newtonsoft.Json;

namespace PokedexNET
{
    public class PokeathlonStats
    {

        [JsonProperty("speed")]
        public IList<int> Speed { get; set; }

        [JsonProperty("power")]
        public IList<int> Power { get; set; }

        [JsonProperty("stamina")]
        public IList<int> Stamina { get; set; }

        [JsonProperty("skill")]
        public IList<int> Skill { get; set; }

        [JsonProperty("jump")]
        public IList<int> Jump { get; set; }
    }
}