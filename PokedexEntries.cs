using Newtonsoft.Json;

namespace PokedexNET
{
    public class PokedexEntries
    {

        [JsonProperty("Diamond")]
        public StringValue Diamond { get; set; }

        [JsonProperty("Pearl")]
        public StringValue Pearl { get; set; }

        [JsonProperty("Platinum")]
        public StringValue Platinum { get; set; }

        [JsonProperty("HeartGold")]
        public StringValue HeartGold { get; set; }

        [JsonProperty("SoulSilver")]
        public StringValue SoulSilver { get; set; }

        [JsonProperty("Black")]
        public StringValue Black { get; set; }

        [JsonProperty("White")]
        public StringValue White { get; set; }

        [JsonProperty("Black 2")]
        public StringValue Black2 { get; set; }

        [JsonProperty("White 2")]
        public StringValue White2 { get; set; }

        [JsonProperty("X")]
        public StringValue X { get; set; }

        [JsonProperty("Y")]
        public StringValue Y { get; set; }

        [JsonProperty("Omega Ruby")]
        public StringValue OmegaRuby { get; set; }

        [JsonProperty("Alpha Sapphire")]
        public StringValue AlphaSapphire { get; set; }
    }
}