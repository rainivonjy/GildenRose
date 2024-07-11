using Xunit;
using System.Collections.Generic;
using GildedRoseKata;
using GildedRoseKata.Services;
using GildedRoseKata.Services.Interfaces;
using GildedRoseKata.Consts;

namespace GildedRoseTests
{
    // Un exemple test pour le service IActionOnQuality donc on devrait faire pareil pour les aures
    public class ActionOnQualityTest
    {
        public IActionOnQuality ActionOnQuality { get; set; }
        public ActionOnQualityTest() 
        {
            ActionOnQuality = new ActionOnQuality();
        }


        /// <summary>
        /// Un exemple de test pour la méthode ActionOnQualityIfAgedBrie mais on devrait faire pareil aussi pour les autres méthodes
        /// </summary>
        [Fact]
        public void ActionOnQualityIfAgedBrie()
        {
            var item = new Item
            {
                Name = NameConst.Aged_Brie,
                Quality = 10,
                SellIn = 11
            };

            ActionOnQuality.ActionOnQualityIfAgedBrie(item);
            // Avant c'était 10 donc on devrait avoir 11 car c'est un Aged Brie
            Assert.Equal(item.Quality, 11);
            // Pou tester le cas contraire
            item.Name = "test1";
            ActionOnQuality.ActionOnQualityIfAgedBrie(item);
            // Vu que ce n'est plus un Aged Brie donc ça reste 11
            Assert.Equal(item.Quality, 11);
        }
    }
}
