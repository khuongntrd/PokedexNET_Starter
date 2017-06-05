using Newtonsoft.Json;

namespace PokedexNET
{
    public class EvYield
    {

        [JsonProperty("hp")]
        public int Hp { get; set; }

        [JsonProperty("atk")]
        public int Atk { get; set; }

        [JsonProperty("def")]
        public int Def { get; set; }

        [JsonProperty("sp_atk")]
        public int SpAtk { get; set; }

        [JsonProperty("sp_def")]
        public int SpDef { get; set; }

        [JsonProperty("speed")]
        public int Speed { get; set; }
    }
}