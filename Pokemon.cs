using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PokedexNET
{
    public class Pokemon
    {
        [JsonProperty("number")]
        public string Number { get; set; }
        [JsonProperty("slug")]
        public string Slug { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonIgnore]
        public string ImageUrl
        {
            get
            {
                if (int.TryParse(Number, out int num))
                {
                    return $"http://assets.pokemon.com/assets/cms2/img/pokedex/detail/{num:D3}.png";
                }
                return string.Empty;
            }
        }


    }

}
