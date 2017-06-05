using System.Collections.Generic;
using Newtonsoft.Json;

namespace PokedexNET
{
    public class Evolution
    {
        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("happiness")]
        public bool Happiness { get; set; }

        [JsonProperty("trade")]
        public bool Trade { get; set; }

        [JsonProperty("level_up")]
        public bool LevelUp { get; set; }

        [JsonProperty("item")]
        public string Item { get; set; }

        [JsonProperty("hold_item")]
        public string HoldItem { get; set; }

        [JsonProperty("move_learned")]
        public string MoveLearned { get; set; }

        [JsonProperty("conditions")]
        public List<string> Conditions { get; set; }
    }
}