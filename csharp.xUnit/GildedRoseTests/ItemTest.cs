using GildedRoseKata;
using Xunit;

namespace GildedRoseTests
{
    public class ItemTest
    {

        /// <summary>
        /// C 'est un exemple de teste sur la class item
        /// </summary>
        [Fact]
        public void IsSellinLessThanEleven()
        {
            var item = new Item
            {
                Name = "name 1",
                SellIn = 10,
                Quality = 2
            };
            Assert.True(item.IsSellinLessThanEleven());
            // Pour tester le cas contraire
            item.SellIn = 12;
            Assert.False(item.IsSellinLessThanEleven());
        }
    }
}
