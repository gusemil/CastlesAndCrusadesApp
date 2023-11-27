using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ExtraOrdinaryItems
{
    public Dictionary<(int, int), ExtraOrdinaryItemType> itemTypeDictionary = new Dictionary<(int, int), ExtraOrdinaryItemType>();

    public ExtraOrdinaryItems()
    {
        itemTypeDictionary.Add((1, 4), new ExtraOrdinaryItemType(0,"'Expert Weapons'"));
        itemTypeDictionary.Add((5, 8), new ExtraOrdinaryItemType(1, "'Jewelry'"));
        itemTypeDictionary.Add((9, 12), new ExtraOrdinaryItemType(2, "'Worn & Ceremonial Items'"));
        itemTypeDictionary.Add((13, 16), new ExtraOrdinaryItemType(3, "'Hand Crafted Items'"));
        itemTypeDictionary.Add((17, 20), new ExtraOrdinaryItemType(4, "'Antiquities'"));
    }
    public void RollItemType()
    {
        int roll = CommonUtils.RollNumber(1, 20);
        ExtraOrdinaryItemType itemType = itemTypeDictionary.Where(x => roll >= x.Key.Item1 && roll <= x.Key.Item2).FirstOrDefault().Value;

        Console.WriteLine("Rolled " + roll + " for extraordinary item type which is " + itemType.subTableDescription + " and table index " + itemType.subTableIndex);

    }
}

public struct ExtraOrdinaryItemType
{
    public int subTableIndex;
    public string subTableDescription;

    public ExtraOrdinaryItemType(int subTableIndex, string subTableDescription)
    {
        this.subTableIndex = subTableIndex;
        this.subTableDescription = subTableDescription;
    }
}
