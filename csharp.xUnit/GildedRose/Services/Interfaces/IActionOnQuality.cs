namespace GildedRoseKata.Services.Interfaces
{
    public interface IActionOnQuality
    {
        public void ActionOnQualityIfNotAgedBrie(Item item);

        public void ActionOnQualityIfAgedBrie(Item item);
        public void ActionOnQualityIfNotSulfurasHandOfRagnaros(Item item);
        public void ActionOnQualityIfBackstagePassessesToATAFKAL80ETCConcert(Item item);
        public void ActionOnQualityIfNotBackstagePassessesToATAFKAL80ETCConcert(Item item);
    }
}
