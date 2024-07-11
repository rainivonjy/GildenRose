namespace GildedRoseKata
{
    /// <summary>
    /// Permet de faire des opérations sur les propriétés Quality et SellIn
    /// </summary>
    public partial class Item
    {
        public void DecreaseQuality() 
        {
            Quality = Quality - 1;
        }

        public void IncreaseQuality()
        {
            if (Quality < 50) 
            {
                Quality = Quality + 1;
            }
        }

        public void DecreaseSellIn()
        {
            SellIn = SellIn - 1;
        }

        public void InitQuality()
        {
            Quality = default;
        }

    }
}
