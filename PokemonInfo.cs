using System.Collections.Generic;
using Newtonsoft.Json;

namespace PokedexNET
{
    public class PokemonInfo
    {

        [JsonProperty("names")]
        public StringValue Names { get; set; }

        [JsonProperty("national_id")]
        public int NationalId { get; set; }

        [JsonProperty("types")]
        public IList<string> Types { get; set; }

        [JsonProperty("abilities")]
        public IList<Ability> Abilities { get; set; }

        [JsonProperty("gender_ratios")]
        public GenderRatios GenderRatios { get; set; }

        [JsonProperty("catch_rate")]
        public int CatchRate { get; set; }

        [JsonProperty("egg_groups")]
        public IList<string> EggGroups { get; set; }

        [JsonProperty("hatch_time")]
        public IList<int> HatchTime { get; set; }

        [JsonProperty("height_us")]
        public string HeightUs { get; set; }

        [JsonProperty("height_eu")]
        public string HeightEu { get; set; }

        [JsonProperty("weight_us")]
        public string WeightUs { get; set; }

        [JsonProperty("weight_eu")]
        public string WeightEu { get; set; }

        [JsonProperty("base_exp_yield")]
        public int BaseExpYield { get; set; }

        [JsonProperty("leveling_rate")]
        public string LevelingRate { get; set; }

        [JsonProperty("ev_yield")]
        public EvYield EvYield { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("base_friendship")]
        public int BaseFriendship { get; set; }

        [JsonProperty("base_stats")]
        public BaseStats BaseStats { get; set; }

        [JsonProperty("learnset")]
        public IList<Learnset> Learnset { get; set; }

        [JsonProperty("evolution_from")]
        public string EvolutionFrom { get; set; }

        [JsonProperty("categories")]
        public StringValue Categories { get; set; }

        [JsonProperty("kanto_id")]
        public string KantoId { get; set; }

        [JsonProperty("johto_id")]
        public string JohtoId { get; set; }

        [JsonProperty("hoenn_id")]
        public string HoennId { get; set; }

        [JsonProperty("sinnoh_id")]
        public string SinnohId { get; set; }

        [JsonProperty("unova_id")]
        public string UnovaId { get; set; }

        [JsonProperty("kalos_id")]
        public string KalosId { get; set; }

        [JsonProperty("alola_id")]
        public string AlolaId { get; set; }

        [JsonProperty("mega_evolutions")]
        public IList<MegaEvolution> MegaEvolutions { get; set; }

        [JsonProperty("evolutions")]
        public IList<Evolution> Evolutions { get; set; }

        [JsonProperty("variations")]
        public IList<string> Variations { get; set; }

        [JsonProperty("pokedex_entries")]
        public PokedexEntries PokedexEntries { get; set; }

        [JsonProperty("pokeathlon_stats")]
        public PokeathlonStats PokeathlonStats { get; set; }
    }
}