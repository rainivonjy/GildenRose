using GildedRoseKata.Consts;
using GildedRoseKata.Services.Interfaces;

namespace GildedRoseKata.Services
{
    public class ActionOnQuality : IActionOnQuality
    {
        public void ActionOnQualityIfNotAgedBrie(Item item)
        {
            if (!item.IsAgedBrie())
            {
                 ActionOnQualityIfNotBackstagePassessesToATAFKAL80ETCConcert(item);
                if(item.IsBackstagePassessesToATAFKAL80ETCConcert())
                {
                    item.InitQuality();
                }
            }
        }

        public void ActionOnQualityIfAgedBrie(Item item)
        {
            if (item.IsAgedBrie())
            {
                item.IncreaseQuality();
            }
        }

        public void ActionOnQualityIfNotSulfurasHandOfRagnaros(Item item)
        {
            if (item.Name != NameConst.Sulfuras_Hand_of_Ragnaros)
            {
                item.DecreaseQuality();
            }
        }

        public void ActionOnQualityIfBackstagePassessesToATAFKAL80ETCConcert(Item item)
        {
            if (item.IsQualiteLessThanFifty())
            {
                if (item.IsBackstagePassessesToATAFKAL80ETCConcert())
                {
                    if (item.IsSellinLessThanSixty())
                    {
                        item.IncreaseQuality();
                        item.IncreaseQuality();
                    }

                    if (item.IsSellinMoreEgalThanSixty() && item.IsSellinLessThanEleven())
                    {
                        item.IncreaseQuality();
                    }
                }
            }  
        }

        public void ActionOnQualityIfNotBackstagePassessesToATAFKAL80ETCConcert(Item item)
        {
            if (!item.IsBackstagePassessesToATAFKAL80ETCConcert())
            {
                if (item.IsQualiteMoreThanZero())
                {
                    if (item.Name != NameConst.Sulfuras_Hand_of_Ragnaros)
                    {
                        item.DecreaseQuality();
                    }
                }
            }
        }
    }
}
