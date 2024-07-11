using GildedRoseKata.Consts;

namespace GildedRoseKata;

public partial class Item
{

    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }


    public bool IsAgedBrie() 
    {
        return Name == NameConst.Aged_Brie;
    }

    public bool IsSellinNegatif()
    {
        return SellIn < 0;
    }
    public bool IsNotAgedBrieAndBackstagePassessesToATAFKAL80ETCConcert()
    {
        return Name != NameConst.Aged_Brie && Name != NameConst.Backstage_passesses_to_a_TAFKAL80ETC_concert;
    }

    public bool IsBackstagePassessesToATAFKAL80ETCConcert()
    {
        return Name == NameConst.Backstage_passesses_to_a_TAFKAL80ETC_concert;
    }

    public bool IsQualiteLessThanFifty()
    {
        return Quality < 50;
    }

    public bool IsQualiteMoreThanZero()
    {
        return Quality > 0;
    }

    public bool IsSellinLessThanSixty()
    {
        return SellIn < 6;
    }

    public bool IsSellinMoreEgalThanSixty()
    {
        return SellIn >= 6;
    }

    public bool IsSellinLessThanEleven()
    {
        return SellIn < 11;
    }

}