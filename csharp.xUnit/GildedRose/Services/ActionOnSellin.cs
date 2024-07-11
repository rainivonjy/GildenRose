using GildedRoseKata.Consts;
using GildedRoseKata.Services.Interfaces;

namespace GildedRoseKata.Services
{
    public class ActionOnSellin : IActionOnSellin
    {
        public void ActionOnSellinIfNotSulfurasHandOfRagnaros(Item item)
        {
            if (item.Name != NameConst.Sulfuras_Hand_of_Ragnaros)
            {
                item.DecreaseSellIn();
            }
        }
    }
}
