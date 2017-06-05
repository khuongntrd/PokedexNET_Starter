using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;

namespace PokedexNET
{
    public class Pokedex
    {
        internal Assembly Assembly { get; }

        public Pokedex()
        {
            Assembly = typeof(Pokedex).GetTypeInfo().Assembly;

            Load();
        }

        internal void Load()
        {
            using (var reader = new StreamReader(Assembly.GetManifestResourceStream("PokedexNET.data.pokemon.json")))
            {
                Pokemons = JsonConvert.DeserializeObject<List<Pokemon>>(reader.ReadToEnd());
            }
        }

        public List<Pokemon> Pokemons { get; set; }

        public Pokemon GetPokemon(int number)
        {
            return Pokemons.FirstOrDefault(x => x.Number == number.ToString("D3"));
        }

        public PokemonInfo GetPokemonInfo(Pokemon pokemon)
        {
            return GetPokemonInfo(pokemon.Slug);
        }
        public PokemonInfo GetPokemonInfo(string slug)
        {
            try
            {
                using (var reader = new StreamReader(Assembly.GetManifestResourceStream($"PokedexNET.data.pokemon.{slug}.json")))
                {
                    return JsonConvert.DeserializeObject<PokemonInfo>(reader.ReadToEnd());
                }
            }
            catch (Exception)
            {
                return null;                
            }
        }
    }
}
