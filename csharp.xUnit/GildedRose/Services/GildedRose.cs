using System.Collections.Generic;
using GildedRoseKata.Consts;
using GildedRoseKata.Services.Interfaces;

namespace GildedRoseKata.Services;

public class GildedRose : IGildedRose
{
    IList<Item> Items;
    public IActionOnSellin ActionOnSellin { get; }
    public IActionOnQuality ActionOnQuality { get; }
    public GildedRose(IList<Item> Items, IActionOnSellin actionOnSellin, IActionOnQuality actionOnQuality)
    {
        this.Items = Items;
        ActionOnSellin = actionOnSellin;
        ActionOnQuality = actionOnQuality;
    }

    public void UpdateQuality()
    {
        for (var i = 0; i < Items.Count; i++)
        {
            if (Items[i].IsNotAgedBrieAndBackstagePassessesToATAFKAL80ETCConcert())
            {
                if (Items[i].IsQualiteMoreThanZero())
                {
                    ActionOnQuality.ActionOnQualityIfNotSulfurasHandOfRagnaros(Items[i]);
                }
            }

            if (!Items[i].IsNotAgedBrieAndBackstagePassessesToATAFKAL80ETCConcert())
            {
                Items[i].IncreaseQuality();
                ActionOnQuality.ActionOnQualityIfBackstagePassessesToATAFKAL80ETCConcert(Items[i]);
            }

            ActionOnSellin.ActionOnSellinIfNotSulfurasHandOfRagnaros(Items[i]);

            if (Items[i].IsSellinNegatif())
            {
                ActionOnQuality.ActionOnQualityIfNotAgedBrie(Items[i]);
                ActionOnQuality.ActionOnQualityIfAgedBrie(Items[i]);
            }
        }
    }
}