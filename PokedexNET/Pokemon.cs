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
        public string ImageFull => $"https://assets.pokemon.com/assets/cms2/img/pokedex/full/{Id:D3}.png";

        [JsonIgnore]
        public string Image => $"https://assets.pokemon.com/assets/cms2/img/pokedex/detail/{Id:D3}.png";
    }

}
