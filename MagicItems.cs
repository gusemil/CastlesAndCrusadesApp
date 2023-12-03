using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MagicItems
{
    public Dictionary<int, MagicItemsTable> magicItemsDictionary = null;
    private Dictionary<(int, int), MagicItemType> magicItemTypesDictionary = null;

    public MagicItems()
    {
        if (magicItemsDictionary != null) return;
        magicItemsDictionary = new Dictionary<int, MagicItemsTable>();
        magicItemsDictionary.Add(0, new MagicItemsTable(5, new Roll(1, 1), 100));
        magicItemsDictionary.Add(1, new MagicItemsTable(10, new Roll(1, 1), 200));
        magicItemsDictionary.Add(2, new MagicItemsTable(15, new Roll(1, 1), 300));
        magicItemsDictionary.Add(3, new MagicItemsTable(20, new Roll(1, 1), 500));
        magicItemsDictionary.Add(4, new MagicItemsTable(30, new Roll(1, 2), 800));
        magicItemsDictionary.Add(5, new MagicItemsTable(40, new Roll(1, 2), 1300));
        magicItemsDictionary.Add(6, new MagicItemsTable(50, new Roll(1, 2), 2100));
        magicItemsDictionary.Add(7, new MagicItemsTable(60, new Roll(1, 2), 3400));
        magicItemsDictionary.Add(8, new MagicItemsTable(70, new Roll(1, 3), 5500));
        magicItemsDictionary.Add(9, new MagicItemsTable(80, new Roll(1, 3)));
        magicItemsDictionary.Add(10, new MagicItemsTable(90, new Roll(1, 3)));
        magicItemsDictionary.Add(11, new MagicItemsTable(92, new Roll(1, 3)));
        magicItemsDictionary.Add(12, new MagicItemsTable(94, new Roll(1, 4)));
        magicItemsDictionary.Add(13, new MagicItemsTable(96, new Roll(1, 4)));
        magicItemsDictionary.Add(14, new MagicItemsTable(98, new Roll(1, 4)));
        magicItemsDictionary.Add(15, new MagicItemsTable(99, new Roll(1, 4)));
        magicItemsDictionary.Add(16, new MagicItemsTable(100, new Roll(1, 6)));
        magicItemsDictionary.Add(17, new MagicItemsTable(100, new Roll(1, 6)));
    }

    private void InitMagicItems()
    {
        if (magicItemTypesDictionary != null) return;
        magicItemTypesDictionary = new Dictionary<(int, int), MagicItemType>();
        magicItemTypesDictionary.Add((1, 15), new MagicItemType(0, "'Potions'"));
        magicItemTypesDictionary.Add((16, 30), new MagicItemType(1, "'Scroll'"));
        magicItemTypesDictionary.Add((31, 45), new MagicItemType(2, "'Armor & Shields'"));
        magicItemTypesDictionary.Add((46, 60), new MagicItemType(3, "'Miscellaneous Magic'"));
        magicItemTypesDictionary.Add((61, 80), new MagicItemType(4, "'Rings'"));
        magicItemTypesDictionary.Add((91, 97), new MagicItemType(4, "'Rods, Staves, Wands'"));
        magicItemTypesDictionary.Add((98, 99), new MagicItemType(4, "'Cursed Items'"));
        magicItemTypesDictionary.Add((100, 100), new MagicItemType(4, "'Artifacts'"));
    }

    public void RollItemType(int itemsAmount)
    {
        InitMagicItems();
        for (int i = 0; i < itemsAmount; i++)
        {
            int roll = CommonUtils.RollPercentage();
            MagicItemType itemType = magicItemTypesDictionary.Where(x => roll >= x.Key.Item1 && roll <= x.Key.Item2).FirstOrDefault().Value;

            Console.WriteLine("Rolled " + roll + " for magic item type which is " + itemType.subTableDescription + " and table index " + itemType.subTableIndex);

            switch (itemType.subTableIndex)
            {
                case 0:
                    RollPotions();
                    break;
                case 1:
                    RollScrolls();
                    break;
                case 2:
                    RollWeapons();
                    break;
                case 3:
                    RollArmorAndShields();
                    break;
                case 4:
                    RollMiscMagic();
                    break;
                case 5:
                    RollRings();
                    break;
                case 6:
                    RollRodsStavesWands();
                    break;
                case 7:
                    RollCursedItems();
                    break;
                case 8:
                    RollArtifacts();
                    break;
                default:
                    Console.WriteLine("Something went wrong");
                    break;
            }
        }
    }

    private void RollPotions()
    {
        
    }

    private void RollScrolls()
    {

    }

    private void RollWeapons()
    {

    }
    
    private void RollArmorAndShields()
    {

    }

    private void RollMiscMagic()
    {

    }

    private void RollRings()
    {

    }

    private void RollRodsStavesWands()
    {

    }

    private void RollCursedItems()
    {

    }

    private void RollArtifacts()
    {

    }

    public struct MagicItemsTable
    {
        public int percentageChance;
        public Roll itemTypeRoll;
        public int maxXpOfItems;

        public MagicItemsTable(int percentageChance, Roll itemTypeRoll, int maxXpOfItems = 0)
        {
            this.percentageChance = percentageChance;
            this.itemTypeRoll = itemTypeRoll;
            this.maxXpOfItems = maxXpOfItems;
        }
    }

    private struct MagicItemType
    {
        public int subTableIndex;
        public string subTableDescription;

        public MagicItemType(int subTableIndex, string subTableDescription)
        {
            this.subTableIndex = subTableIndex;
            this.subTableDescription = subTableDescription;
        }
    }
}

