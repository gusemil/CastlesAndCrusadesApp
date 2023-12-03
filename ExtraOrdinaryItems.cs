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
    private Dictionary<(int, int), Item> jewelryDictionary = null;
    private Dictionary<(int, int), Item> wornAndCeremonialDictionary = null;
    private Dictionary<(int, int), Item> handcraftedDictionary = null;
    private Dictionary<(int, int), Item> antiquitiesDictionary = null;

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
        expertWeaponsDictionary.Add((1, 5), new Item("'Arrow'", 1, 0));
        expertWeaponsDictionary.Add((6, 10), new Item("'Battle Axe'", 100, 0));
        expertWeaponsDictionary.Add((11, 15), new Item("'Bolt'", 12, 0, "'Gp value in sp'"));
        expertWeaponsDictionary.Add((16, 20), new Item("'Bow'", 0, 0, "'Type is Castle Keeper's Choice. Value varies'"));
        expertWeaponsDictionary.Add((21, 25), new Item("'Crossbow'", 0, 0, "'Type is Castle Keeper's Choice. Value varies'"));
        expertWeaponsDictionary.Add((26, 30), new Item("'Dagger'", 20));
        expertWeaponsDictionary.Add((31, 35), new Item("'Dart'", 0, 0, "'Type is Castle Keeper's Choice. Value varies'"));
        expertWeaponsDictionary.Add((36, 40), new Item("'Flail'", 0, 0, "'Type is Castle Keeper's Choice. Value varies'"));
        expertWeaponsDictionary.Add((41, 45), new Item("'Halberd'", 100));
        expertWeaponsDictionary.Add((46, 50), new Item("'Hammer'", 0, 0, "'Type is Castle Keeper's Choice. Value varies'"));
        expertWeaponsDictionary.Add((51, 55), new Item("'Hand Axe'", 40));
        expertWeaponsDictionary.Add((56, 60), new Item("'Javelin'", 10));
        expertWeaponsDictionary.Add((61, 65), new Item("'Lance'", 0, 0, "'Type is Castle Keeper's Choice. Value varies'"));
        expertWeaponsDictionary.Add((66, 70), new Item("'Mace'", 0, 0, "'Type is Castle Keeper's Choice. Value varies'"));
        expertWeaponsDictionary.Add((71, 75), new Item("'Morningstar'", 80));
        expertWeaponsDictionary.Add((76, 80), new Item("'Scimitar'", 150));
        expertWeaponsDictionary.Add((81, 85), new Item("'Spear'", 0, 0, "'Type is Castle Keeper's Choice. Value varies'"));
        expertWeaponsDictionary.Add((86, 90), new Item("'Sword'", 0, 0, "'Type is Castle Keeper's Choice. Value varies'"));
        expertWeaponsDictionary.Add((91, 95), new Item("'Trident'", 100));
        expertWeaponsDictionary.Add((96, 100), new Item("'Two-Handed Axe'", 300));
    }

    private void InitJewelry()
    {
        if (jewelryDictionary != null) return;
        jewelryDictionary = new Dictionary<(int, int), Item>();
        //gp value of all is based on the value table
        jewelryDictionary.Add((1, 5), new Item("'Ankle Chain'", 0, 0, "", 0, true));
        jewelryDictionary.Add((6, 10), new Item("'Arm Band'", 0, 0, "", 0, true));
        jewelryDictionary.Add((11, 15), new Item("'Belt'", 0, 0, "", 0, true));
        jewelryDictionary.Add((16, 20), new Item("'Bracelet'", 0, 0, "", 0, true));
        jewelryDictionary.Add((21, 25), new Item("'Broach'", 0, 0, "", 0, true));
        jewelryDictionary.Add((26, 30), new Item("'Buckle'", 0, 0, "", 0, true));
        jewelryDictionary.Add((31, 35), new Item("'Button'", 0, 0, "'2-4 buttons, each button 1gp worth'", 0, true));
        jewelryDictionary.Add((36, 40), new Item("'Collar'", 0, 0, "", 0, true));
        jewelryDictionary.Add((41, 45), new Item("'Choker'", 0, 0, "", 0, true));
        jewelryDictionary.Add((46, 50), new Item("'Earrings'", 0, 0, "", 0, true));
        jewelryDictionary.Add((51, 55), new Item("'Locket'", 0, 0, "", 0, true));
        jewelryDictionary.Add((56, 60), new Item("'Medallion'", 0, 0, "", 0, true));
        jewelryDictionary.Add((61, 65), new Item("'Necklace'", 0, 0, "", 0, true));
        jewelryDictionary.Add((66, 70), new Item("'Pendant'", 0, 0, "", 0, true));
        jewelryDictionary.Add((71, 75), new Item("'Ring'", 0, 0, "", 0, true));
        jewelryDictionary.Add((76, 80), new Item("'Stud'", 0, 0, "", 0, true));
        jewelryDictionary.Add((81, 85), new Item("'Tiara'", 0, 0, "", 0, true));
        jewelryDictionary.Add((86, 90), new Item("'Toe Ring'", 0, 0, "", 0, true));
        jewelryDictionary.Add((91, 95), new Item("'Torque'", 0, 0, "", 0, true));
        jewelryDictionary.Add((96, 100), new Item("'Waist Chain'", 0, 0, "", 0, true));
    }

    private void InitWornAndCeremonial()
    {
        if (wornAndCeremonialDictionary != null) return;
        wornAndCeremonialDictionary = new Dictionary<(int, int), Item>();
        //gp value of all is based on the value table
        wornAndCeremonialDictionary.Add((1, 5), new Item("'Coronet'", 0, 0, "", 0, true));
        wornAndCeremonialDictionary.Add((6, 10), new Item("'Crown'", 0, 0, "", 0, true));
        wornAndCeremonialDictionary.Add((11, 15), new Item("'Orb'", 0, 0, "", 0, true));
        wornAndCeremonialDictionary.Add((16, 20), new Item("'Scepter'", 0, 0, "", 0, true));
        wornAndCeremonialDictionary.Add((21, 25), new Item("'Signet ring'", 0, 0, "", 0, true));
        wornAndCeremonialDictionary.Add((26, 30), new Item("'Holy Symbol'", 0, 0, "", 0, true));
        wornAndCeremonialDictionary.Add((31, 35), new Item("'Holy water'", 0, 0, "'water container?'", 0, true));
        wornAndCeremonialDictionary.Add((36, 40), new Item("'Idol'", 0, 0, "'Relics include bones of saints, iconographic statues, or anything else that may be holy to a religious group.'", 0, true));
        wornAndCeremonialDictionary.Add((41, 45), new Item("'Relic'", 0, 0, "", 0, true));
        wornAndCeremonialDictionary.Add((46, 50), new Item("'Rune Stones'", 0, 0, "", 0, true));
        wornAndCeremonialDictionary.Add((51, 55), new Item("'Fur coat'", 0, 0, "", 0, false, new Roll(2, 10)));
        wornAndCeremonialDictionary.Add((56, 60), new Item("'Hair shirt'", 0, 0, "", 0, false, new Roll(1, 10)));
        wornAndCeremonialDictionary.Add((61, 65), new Item("'Leather jerkin'", 0, 0, "", 0, false, new Roll(2, 10)));
        wornAndCeremonialDictionary.Add((66, 70), new Item("'Oilskin cloth'", 0, 0, "", 0, false, new Roll(2, 10)));
        wornAndCeremonialDictionary.Add((71, 75), new Item("'Silk garment'", 0, 0, "", 0, false, new Roll(5, 10)));
        wornAndCeremonialDictionary.Add((76, 80), new Item("'Gown'", 0, 0, "", 0, false, new Roll(1, 10)));
        wornAndCeremonialDictionary.Add((81, 85), new Item("'Hood'", 0, 0, "", 0, false, new Roll(1, 4)));
        wornAndCeremonialDictionary.Add((86, 90), new Item("'Mantle'", 0, 0, "", 0, false, new Roll(1, 4)));
        wornAndCeremonialDictionary.Add((91, 95), new Item("'Surcoat'", 0, 0, "", 0, false, new Roll(3, 10)));
        wornAndCeremonialDictionary.Add((96, 100), new Item("'Tabard'", 0, 0, "", 0, false, new Roll(2, 10)));
    }

    private void InitHandCrafted()
    {
        if (handcraftedDictionary != null) return;
        handcraftedDictionary = new Dictionary<(int, int), Item>();
        //gp value of all is based on the value table
        handcraftedDictionary.Add((1, 5), new Item("'Wooden bird cage'", 20));
        handcraftedDictionary.Add((6, 10), new Item("'Ivory pipe'", 50));
        handcraftedDictionary.Add((11, 15), new Item("'Paper, ink & quill'", 15, 0, "These should come in a scroll case or box"));
        handcraftedDictionary.Add((16, 20), new Item("'Silver snuff box'", 100));
        handcraftedDictionary.Add((21, 25), new Item("'Mechnical toy'", 0, 0, "", 0, false, new Roll(2, 10)));
        handcraftedDictionary.Add((26, 30), new Item("'China place settings'", 0, 0, "from 1-12 are found, value is per setting", 0, false, new Roll(2, 6, 0, 10), new Roll(1, 12)));
        handcraftedDictionary.Add((31, 35), new Item("''Crystal vase", 0, 0, "", 0, false, new Roll(10, 10)));
        handcraftedDictionary.Add((36, 40), new Item("'Pewter goblet'", 2));
        handcraftedDictionary.Add((41, 45), new Item("'Trencher, silver plated'", 4));
        handcraftedDictionary.Add((46, 50), new Item("'Wooden gourd'", 1));
        handcraftedDictionary.Add((51, 55), new Item("'Golden harp'", 0, 0, "", 0, true));
        handcraftedDictionary.Add((56, 60), new Item("'Hunter's horn'", 0, 0, "", 0, true));
        handcraftedDictionary.Add((61, 65), new Item("'Lute of Vaughn'", 120));
        handcraftedDictionary.Add((66, 70), new Item("'Elven mandolin'", 100));
        handcraftedDictionary.Add((71, 75), new Item("'Dragonclaw panpipes'", 500));
        handcraftedDictionary.Add((76, 80), new Item("'Animal pelt'", 0, 0, "Cured. The value of any pelt ranges from 10 gp to 1000 gp depending on locale and rarity", 0, false, new Roll(10, 1000)));
        handcraftedDictionary.Add((81, 85), new Item("'Decorative egg'", 100));
        handcraftedDictionary.Add((86, 90), new Item("'Statue'", 0, 0, "", 0, true));
        handcraftedDictionary.Add((91, 95), new Item("'Carved wood'", 0, 0, "", 0, true));
        handcraftedDictionary.Add((96, 100), new Item("'Miniature figurine'", 0, 0, "", 0, true));
    }

    private void InitAntiques()
    {
        //FIXME: One of the items caused a crash. Which one?
        if (antiquitiesDictionary != null) return;
        antiquitiesDictionary = new Dictionary<(int, int), Item>();
        //gp value of all is based on the value table
        antiquitiesDictionary.Add((1, 5), new Item("'Book(s)'", 0, 0, "Books, charts and maps can contain anything from histories amd geographical references to treasure maps and nautical charts", 0, false, new Roll(10, 10)));
        antiquitiesDictionary.Add((6, 10), new Item("'Charts'", 0, 0, "Books, charts and maps can contain anything from histories amd geographical references to treasure maps and nautical charts", 0, false, new Roll(5, 10)));
        antiquitiesDictionary.Add((11, 15), new Item("'Map'", 0, 0, "Books, charts and maps can contain anything from histories amd geographical references to treasure maps and nautical charts", 0, false, new Roll(5, 10)));
        antiquitiesDictionary.Add((16, 20), new Item("'Scroll'", 0, 0, "", 0, false, new Roll(10, 10)));
        antiquitiesDictionary.Add((21, 25), new Item("'Stone'", 0, 0, "", 0, false, new Roll(10, 10, 10)));
        antiquitiesDictionary.Add((26, 30), new Item("'Banner'", 250));
        antiquitiesDictionary.Add((31, 35), new Item("'Painting'", 0, 0, "", 0, false, new Roll(10, 10, 10)));
        antiquitiesDictionary.Add((36, 40), new Item("'Rug'", 0, 0, "", 0, false, new Roll(10, 10, 10)));
        antiquitiesDictionary.Add((41, 45), new Item("'Tapestry'", 0, 0, "", 0, false, new Roll(10, 10, 100)));
        antiquitiesDictionary.Add((46, 50), new Item("'Trophy'", 0, 0, "", 0, false, new Roll(10, 10)));
        antiquitiesDictionary.Add((51, 55), new Item("'Brazier'", 0, 0, "", 0, true));
        antiquitiesDictionary.Add((56, 60), new Item("'Candlelabra'", 0, 0, "", 0, true));
        antiquitiesDictionary.Add((61, 65), new Item("'Coffer'", 0, 0, "", 0, true));
        antiquitiesDictionary.Add((66, 70), new Item("'Urn'", 0, 0, "", 0, true));
        antiquitiesDictionary.Add((71, 75), new Item("'Death Mask'", 0, 0, "", 0, true));
        antiquitiesDictionary.Add((76, 80), new Item("'Hour glass'", 0, 0, "", 0, true));
        antiquitiesDictionary.Add((81, 85), new Item("'Music box'", 0, 0, "", 0, true));
        antiquitiesDictionary.Add((86, 90), new Item("'Mirror'", 0, 0, "", 0, true));
        antiquitiesDictionary.Add((91, 95), new Item("'Wine'", 0, 0, "", 0, false, new Roll(2, 10, 10)));
        antiquitiesDictionary.Add((96, 100), new Item("'Troll knuckles'", 0, 0, "", 0, true));
    }

    private void RollExpertWeapon()
    {
        InitExpertWeapons(); //Replace with a delegate?
        int roll = CommonUtils.RollPercentage();
        Item expertWeaponEntry = expertWeaponsDictionary.Where(x => roll >= x.Key.Item1 && roll <= x.Key.Item2).FirstOrDefault().Value;
        Item expertWeapon = new Item(expertWeaponEntry.name, expertWeaponEntry.gp, expertWeaponEntry.xp, expertWeaponEntry.description, expertWeaponEntry.pageNumber, expertWeaponEntry.isRollValueTable, expertWeaponEntry.rollGpValue);
        Console.WriteLine("Rolled " + roll + " for extraordinary weapon type which is... ");
        expertWeapon.PrintInfo();
    }

    private void RollJewelry()
    {
        InitJewelry(); //Replace with a delegate?
        int roll = CommonUtils.RollPercentage();
        Item jewelryEntry = jewelryDictionary.Where(x => roll >= x.Key.Item1 && roll <= x.Key.Item2).FirstOrDefault().Value;
        Item jewelry = new Item(jewelryEntry.name, jewelryEntry.gp, jewelryEntry.xp, jewelryEntry.description, jewelryEntry.pageNumber, jewelryEntry.isRollValueTable, jewelryEntry.rollGpValue);
        Console.WriteLine("Rolled " + roll + " for jewelry item type which is... ");
        jewelry.RollValueTable();
        jewelry.PrintInfo();
    }

    private void RollWornAndCeremonial()
    {
        InitWornAndCeremonial(); //Replace with a delegate?
        int roll = CommonUtils.RollPercentage();
        Item wornAndCeremonialEntry = wornAndCeremonialDictionary.Where(x => roll >= x.Key.Item1 && roll <= x.Key.Item2).FirstOrDefault().Value;
        Item wornAndCeremonial = new Item(wornAndCeremonialEntry.name, wornAndCeremonialEntry.gp, wornAndCeremonialEntry.xp, wornAndCeremonialEntry.description, wornAndCeremonialEntry.pageNumber, wornAndCeremonialEntry.isRollValueTable, wornAndCeremonialEntry.rollGpValue);
        Console.WriteLine("Rolled " + roll + " for worn and ceremonial item type which is... ");
        wornAndCeremonial.RollGpValue();
        wornAndCeremonial.RollValueTable();
        wornAndCeremonial.PrintInfo();
    }

    private void RollHandcrafted()
    {
        InitHandCrafted(); //Replace with a delegate?
        int roll = 26;//CommonUtils.RollPercentage();
        Item handcraftedEntry = handcraftedDictionary.Where(x => roll >= x.Key.Item1 && roll <= x.Key.Item2).FirstOrDefault().Value;
        Item handcrafted = new Item(handcraftedEntry.name, handcraftedEntry.gp, handcraftedEntry.xp, handcraftedEntry.description, handcraftedEntry.pageNumber, handcraftedEntry.isRollValueTable, handcraftedEntry.rollGpValue);
        Console.WriteLine("Rolled " + roll + " for handcrafted item type which is... ");
        handcrafted.RollAmount();
        handcrafted.RollGpValue();
        handcrafted.RollValueTable();
        handcrafted.PrintInfo();
    }

    private void RollAntiques()
    {
        //FIXME: One of the items caused a crash. Which one?
        InitAntiques(); //Replace with a delegate?
        int roll = CommonUtils.RollPercentage();
        Item antiquitiesEntry = antiquitiesDictionary.Where(x => roll >= x.Key.Item1 && roll <= x.Key.Item2).FirstOrDefault().Value;
        Item antiquities = new Item(antiquitiesEntry.name, antiquitiesEntry.gp, antiquitiesEntry.xp, antiquitiesEntry.description, antiquitiesEntry.pageNumber, antiquitiesEntry.isRollValueTable, antiquitiesEntry.rollGpValue);
        Console.WriteLine("Rolled " + roll + " for antiques item type which is... ");
        antiquities.RollAmount();
        antiquities.RollGpValue();
        antiquities.RollValueTable();
        antiquities.PrintInfo();
    }

    public void RollItemType(int itemsAmount)
    {
        InitExtraOrdinaryItems();
        for (int i = 0; i < itemsAmount; i++)
        {
            int roll = CommonUtils.RollNumber(1, 20);
            ExtraOrdinaryItemType itemType = itemTypeDictionary.Where(x => roll >= x.Key.Item1 && roll <= x.Key.Item2).FirstOrDefault().Value;

            Console.WriteLine("Rolled " + roll + " for extraordinary item type which is " + itemType.subTableDescription + " and table index " + (itemType.subTableIndex +1));

            switch (itemType.subTableIndex)
            {
                case 0:
                    RollExpertWeapon();
                    break;
                case 1:
                    RollJewelry();
                    break;
                case 2:
                    RollWornAndCeremonial();
                    break;
                case 3:
                    RollHandcrafted();
                    break;
                case 4:
                    RollAntiques();
                    break;
                default:
                    Console.WriteLine("Something went wrong");
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
