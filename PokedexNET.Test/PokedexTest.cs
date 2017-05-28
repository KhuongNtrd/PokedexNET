using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PokedexNET.Test
{
    [TestClass]
    public class PokedexTest
    {
        [TestMethod]
        public void Creation()
        {
            var pok = new Pokedex();
            Assert.AreNotEqual(pok.Pokemons?.Count, null);
        }

        [TestMethod]
        public void GetInfo()
        {
           var pok = new Pokedex();
            var info = pok.GetPokemonInfo(pok.Pokemons.OrderBy(x => Guid.NewGuid()).First());
            Assert.AreNotEqual(info, null);
        }
    }
}
