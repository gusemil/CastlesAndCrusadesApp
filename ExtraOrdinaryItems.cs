using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ExtraOrdinaryItems
{
    public Dictionary<int, ExtraOrdinaryItemsTable> extraOrdinaryItemsDictionary = null;
    private Dictionary<(int, int), ExtraOrdinaryItemType> itemTypeDictionary = null;
    private Dictionary<(int, int), Item> expertWeaponsDictionary = null;

    public ExtraOrdinaryItems()
    {
        if (extraOrdinaryItemsDictionary != null) return;
        extraOrdinaryItemsDictionary = new Dictionary<int, ExtraOrdinaryItemsTable>();
        //Init table entries
        extraOrdinaryItemsDictionary.Add(0, new ExtraOrdinaryItemsTable(10, new Roll(1, 2, 0)));
        extraOrdinaryItemsDictionary.Add(1, new ExtraOrdinaryItemsTable(20, new Roll(1, 2, 1)));
        extraOrdinaryItemsDictionary.Add(2, new ExtraOrdinaryItemsTable(30, new Roll(1, 2, 2)));
        extraOrdinaryItemsDictionary.Add(3, new ExtraOrdinaryItemsTable(40, new Roll(1, 2, 3)));
        extraOrdinaryItemsDictionary.Add(4, new ExtraOrdinaryItemsTable(50, new Roll(1, 4, 2)));
        extraOrdinaryItemsDictionary.Add(5, new ExtraOrdinaryItemsTable(60, new Roll(1, 4, 3)));
        extraOrdinaryItemsDictionary.Add(6, new ExtraOrdinaryItemsTable(70, new Roll(1, 4, 4)));
        extraOrdinaryItemsDictionary.Add(7, new ExtraOrdinaryItemsTable(80, new Roll(1, 4, 5)));
        extraOrdinaryItemsDictionary.Add(8, new ExtraOrdinaryItemsTable(90, new Roll(1, 6, 4)));
        extraOrdinaryItemsDictionary.Add(9, new ExtraOrdinaryItemsTable(91, new Roll(1, 6, 5)));
        extraOrdinaryItemsDictionary.Add(10, new ExtraOrdinaryItemsTable(92, new Roll(1, 6, 6)));
        extraOrdinaryItemsDictionary.Add(11, new ExtraOrdinaryItemsTable(93, new Roll(1, 6, 7)));
        extraOrdinaryItemsDictionary.Add(12, new ExtraOrdinaryItemsTable(94, new Roll(1, 8, 6)));
        extraOrdinaryItemsDictionary.Add(13, new ExtraOrdinaryItemsTable(95, new Roll(1, 8, 7)));
        extraOrdinaryItemsDictionary.Add(14, new ExtraOrdinaryItemsTable(96, new Roll(1, 8, 8)));
        extraOrdinaryItemsDictionary.Add(15, new ExtraOrdinaryItemsTable(97, new Roll(1, 8, 9)));
        extraOrdinaryItemsDictionary.Add(16, new ExtraOrdinaryItemsTable(98, new Roll(1, 10, 8)));
        extraOrdinaryItemsDictionary.Add(17, new ExtraOrdinaryItemsTable(99, new Roll(1, 10, 9)));
    }

    private void InitExtraOrdinaryItems()
    {
        if (itemTypeDictionary != null) return;
        itemTypeDictionary = new Dictionary<(int, int), ExtraOrdinaryItemType>();
        itemTypeDictionary.Add((1, 4), new ExtraOrdinaryItemType(0, "'Expert Weapons'"));
        itemTypeDictionary.Add((5, 8), new ExtraOrdinaryItemType(1, "'Jewelry'"));
        itemTypeDictionary.Add((9, 12), new ExtraOrdinaryItemType(2, "'Worn & Ceremonial Items'"));
        itemTypeDictionary.Add((13, 16), new ExtraOrdinaryItemType(3, "'Hand Crafted Items'"));
        itemTypeDictionary.Add((17, 20), new ExtraOrdinaryItemType(4, "'Antiquities'"));
    }

    private void InitExpertWeapons()
    {
        if (expertWeaponsDictionary != null) return;
        expertWeaponsDictionary = new Dictionary<(int, int), Item>();
        expertWeaponsDictionary.Add((1, 5), new Item("'Arrow'", 1));
        expertWeaponsDictionary.Add((6, 10), new Item("'Battle Axe'", 100));
        expertWeaponsDictionary.Add((11, 15), new Item("'Bolt'", 12, "'Gp value in sp'"));
        expertWeaponsDictionary.Add((16, 20), new Item("'Bow'", 0,"'Type is Castle Keeper's Choice. Value varies'"));
        expertWeaponsDictionary.Add((21, 25), new Item("'Crossbow'", 0, "'Type is Castle Keeper's Choice. Value varies'"));
        expertWeaponsDictionary.Add((26, 30), new Item("'Dagger'", 20));
        expertWeaponsDictionary.Add((31, 35), new Item("'Dart'", 0, "'Type is Castle Keeper's Choice. Value varies'"));
        expertWeaponsDictionary.Add((36, 40), new Item("'Flail'", 0, "'Type is Castle Keeper's Choice. Value varies'"));
        expertWeaponsDictionary.Add((41, 45), new Item("'Halberd'", 100));
        expertWeaponsDictionary.Add((46, 50), new Item("'Hammer'", 0, "'Type is Castle Keeper's Choice. Value varies'"));
        expertWeaponsDictionary.Add((51, 55), new Item("'Hand Axe'", 40));
        expertWeaponsDictionary.Add((56, 60), new Item("'Javelin'", 10));
        expertWeaponsDictionary.Add((61, 65), new Item("'Lance'", 0, "'Type is Castle Keeper's Choice. Value varies'"));
        expertWeaponsDictionary.Add((66, 70), new Item("'Mace'", 0, "'Type is Castle Keeper's Choice. Value varies'"));
        expertWeaponsDictionary.Add((71, 75), new Item("'Morningstar'", 80));
        expertWeaponsDictionary.Add((76, 80), new Item("'Scimitar'", 150));
        expertWeaponsDictionary.Add((81, 85), new Item("'Spear'", 0, "'Type is Castle Keeper's Choice. Value varies'"));
        expertWeaponsDictionary.Add((86, 90), new Item("'Sword'", 0, "'Type is Castle Keeper's Choice. Value varies'"));
        expertWeaponsDictionary.Add((91, 95), new Item("'Trident'", 100));
        expertWeaponsDictionary.Add((96, 100), new Item("'Two-Handed Axe'", 300));
    }

    private void InitJewelry()
    {

    }

    private void RollExpertWeapon()
    {
        InitExpertWeapons();
        int roll = CommonUtils.RollPercentage();
        Item expertWeapon = expertWeaponsDictionary.Where(x => roll >= x.Key.Item1 && roll <= x.Key.Item2).FirstOrDefault().Value;
        Console.WriteLine("Rolled " + roll + " for extraordinary weapon type which is... ");
        expertWeapon.PrintInfo();
    }

    public void RollItemType(int itemsAmount)
    {
        InitExtraOrdinaryItems();
        for (int i = 0; i < itemsAmount; i++)
        {
            int roll = CommonUtils.RollNumber(1, 20);
            ExtraOrdinaryItemType itemType = itemTypeDictionary.Where(x => roll >= x.Key.Item1 && roll <= x.Key.Item2).FirstOrDefault().Value;

            Console.WriteLine("Rolled " + roll + " for extraordinary item type which is " + itemType.subTableDescription + " and table index " + itemType.subTableIndex);

            switch (itemType.subTableIndex)
            {
                case 0:
                    RollExpertWeapon();
                    break;
                default:
                    RollExpertWeapon();
                    //Console.WriteLine("Something went wrong");
                    break;
            }
        }
    }

    public struct ExtraOrdinaryItemsTable
    {
        public int percentageChance;
        public Roll itemsRoll;

        public ExtraOrdinaryItemsTable(int percentageChance, Roll itemsRoll)
        {
            this.percentageChance = percentageChance;
            this.itemsRoll = itemsRoll;
        }
    }

    private struct ExtraOrdinaryItemType
    {
        public int subTableIndex;
        public string subTableDescription;

        public ExtraOrdinaryItemType(int subTableIndex, string subTableDescription)
        {
            this.subTableIndex = subTableIndex;
            this.subTableDescription = subTableDescription;
        }
    }
}
