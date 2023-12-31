﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MagicItems
{
    public Dictionary<int, MagicItemsTable> magicItemsDictionary = null;
    private Dictionary<(int, int), MagicItemType> magicItemTypesDictionary = null;
    private Dictionary<(int, int), Item> potionsDictionary = null;
    private Dictionary<(int, int), Item> scrollsDictionary = null;
    private Dictionary<(int, int), MagicItemType> magicWeaponTypeDictionary = null;
    private Dictionary<(int, int), MagicItemType> magicSwordTypeDictionary = null;
    private Dictionary<(int, int), MagicItem> specialSwordDictionary = null;
    private Dictionary<(int, int), ItemBonus> itemBonusDictionary = null;

    private Dictionary<(int, int), MagicItemType> baneDictionary = null;
    private Dictionary<(int, int), MagicItemType> dragonDictionary = null;

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
        magicItemTypesDictionary.Add((31, 45), new MagicItemType(2, "'Weapon'"));
        magicItemTypesDictionary.Add((46, 60), new MagicItemType(3, "'Armor & Shields'"));
        magicItemTypesDictionary.Add((61, 80), new MagicItemType(4, "'Miscellaneous Magic'"));
        magicItemTypesDictionary.Add((81, 90), new MagicItemType(5, "'Rings'"));
        magicItemTypesDictionary.Add((91, 97), new MagicItemType(6, "'Rods, Staves, Wands'"));
        magicItemTypesDictionary.Add((98, 99), new MagicItemType(7, "'Cursed Items'"));
        magicItemTypesDictionary.Add((100, 100), new MagicItemType(8, "'Artifacts'"));
    }

    private Dictionary<(int, int), Item> InitPotions()
    {
        if (potionsDictionary != null) return potionsDictionary;
        potionsDictionary = new Dictionary<(int, int), Item>();

        potionsDictionary.Add((1, 3), new Item("'Aid'", 400, 200));
        potionsDictionary.Add((4, 6), new Item("'Bless oil'", 300, 100));
        potionsDictionary.Add((7, 9), new Item("'Blur", 400, 200));
        potionsDictionary.Add((10, 12), new Item("'Clairaudience/Clairvoyance'", 500, 300));
        potionsDictionary.Add((13, 15), new Item("'Cure Light Wounds'", 300, 100));
        potionsDictionary.Add((16, 18), new Item("'Cure Serious Wounds'", 500, 300));
        potionsDictionary.Add((19, 21), new Item("'Cure Critical Wounds'", 700, 500));
        potionsDictionary.Add((22, 24), new Item("'Delay Poison'", 400, 200));
        potionsDictionary.Add((25, 27), new Item("'Endure Elements'", 300, 100));
        potionsDictionary.Add((28, 30), new Item("'Fly'", 500, 300));
        potionsDictionary.Add((31, 33), new Item("'Gaseous Form'", 500, 300));
        potionsDictionary.Add((34, 36), new Item("'Giant Strength'", 700, 500, "Roll 1d6 between 19-24 STR (+3 - +6 STR mod)")); //TODO: roll for giant type
        potionsDictionary.Add((37, 39), new Item("'Haste'", 500, 300));
        potionsDictionary.Add((40, 42), new Item("'Heal'", 800, 600));
        potionsDictionary.Add((43, 45), new Item("'Invisibility (potion or oil)'", 400, 200));
        potionsDictionary.Add((46, 48), new Item("'Levitation (potion or oil)'", 400, 200));
        potionsDictionary.Add((49, 51), new Item("'Longevity'", 12000, 1500, "Exilir of youth: 2-12 off age. A small chance to reverse effect and age 1-6 years. CK must determine this chance on campaign and situation"));
        potionsDictionary.Add((52, 54), new Item("'Neutralize Poison'", 600, 400));
        potionsDictionary.Add((55, 57), new Item("'Nondetection'", 500, 300));
        potionsDictionary.Add((58, 60), new Item("'Pass without Trace'", 300, 100));
        potionsDictionary.Add((61, 63), new Item("'Protection from Alignment'", 300, 100, "Character gains +2 AC and Saves against alignment of CK's choice. Lasts 2 rounds per level of the creator"));
        potionsDictionary.Add((64, 66), new Item("'Protection from Arrows'", 500, 300));
        potionsDictionary.Add((67, 69), new Item("'Remove Blindess/deafness'", 500, 300));
        potionsDictionary.Add((70, 72), new Item("'Remove Curse'", 500, 300));
        potionsDictionary.Add((73, 75), new Item("'Remove Paralysis'", 400, 200));
        potionsDictionary.Add((76, 78), new Item("'Restoration'", 700, 400));
        potionsDictionary.Add((79, 81), new Item("'Sanctuary'", 300, 100));
        potionsDictionary.Add((82, 84), new Item("'Shield of Faith +2'", 300, 100));
        potionsDictionary.Add((85, 87), new Item("'Spider Climb'", 300, 100));
        potionsDictionary.Add((88, 90), new Item("'Tongues'", 500, 300));
        potionsDictionary.Add((91, 93), new Item("'Water Breathing'", 500, 300));
        potionsDictionary.Add((94, 96), new Item("'Water Walk'", 900, 700));
        potionsDictionary.Add((97, 99), new Item("'Remove Disease'", 500, 300));
        potionsDictionary.Add((100, 100), new Item("'Trap the Soul'", 1100, 900, "Greenish, thick liquid, usually held in a crystal jar. Within the jar is a small topaz gem. The potion has no taste. Consuming the potion forces the user into the gem as if by a trap the soul spell"));

        return potionsDictionary;
    }

    private Dictionary<(int, int), Item> InitScrolls()
    {
        if (scrollsDictionary != null) return scrollsDictionary;
        scrollsDictionary = new Dictionary<(int, int), Item>();

        //TODO: roll random spells for spell levels?
        scrollsDictionary.Add((1, 8), new Item("'1 Spell Level'", 300, 100));
        scrollsDictionary.Add((9, 16), new Item("'2 Spell Level'", 400, 200));
        scrollsDictionary.Add((17, 24), new Item("'3 Spell Level", 500, 300));
        scrollsDictionary.Add((25, 32), new Item("'4 Spell Level'", 600, 400));
        scrollsDictionary.Add((33, 40), new Item("'5 Spell Level'", 700, 500));
        scrollsDictionary.Add((41, 45), new Item("'6 Spell Level'", 800, 600));
        scrollsDictionary.Add((46, 50), new Item("'7 Spell Level", 900, 700));
        scrollsDictionary.Add((51, 55), new Item("'8 Spell Level'", 1000, 800));
        scrollsDictionary.Add((56, 60), new Item("'9 Spell Level'", 1100, 900));
        scrollsDictionary.Add((61, 65), new Item("'10 Spell Level'", 1200, 1000));
        scrollsDictionary.Add((66, 68), new Item("'11 Spell Level'", 1300, 1100));
        scrollsDictionary.Add((69, 71), new Item("'12 Spell Level'", 1400, 1200));
        scrollsDictionary.Add((72, 74), new Item("'13 Spell Level'", 1500, 1300));
        scrollsDictionary.Add((75, 77), new Item("'14 Spell Level'", 1600, 1400));
        scrollsDictionary.Add((78, 80), new Item("'15 Spell Level'", 1700, 1500));
        scrollsDictionary.Add((81, 82), new Item("'Teleport without Error'", 900, 700));
        scrollsDictionary.Add((83, 84), new Item("'Symbol'", 1000, 800));
        scrollsDictionary.Add((85, 86), new Item("'Trap the Soul'", 1100, 900));
        scrollsDictionary.Add((87, 88), new Item("'Time Stop'", 1100, 900));
        scrollsDictionary.Add((89, 90), new Item("'True Resurrection'", 1100, 900));
        scrollsDictionary.Add((91, 92), new Item("'Mass Heal'", 1000, 800));
        scrollsDictionary.Add((93, 94), new Item("'Gate'", 1100, 900));
        scrollsDictionary.Add((95, 96), new Item("'Create Greater Undead'", 1000, 800));
        scrollsDictionary.Add((97, 98), new Item("'Shape Change'", 1100, 900));
        scrollsDictionary.Add((99, 100), new Item("'Clone'", 1100, 900));

        return scrollsDictionary;
    }

    private void InitMagicWeaponType()
    {
        if (magicWeaponTypeDictionary != null) return;
        magicWeaponTypeDictionary = new Dictionary<(int, int), MagicItemType>();

        magicWeaponTypeDictionary.Add((1, 40), new MagicItemType(0, "Swords"));
        magicWeaponTypeDictionary.Add((41, 50), new MagicItemType(1, "Special Sword"));
        magicWeaponTypeDictionary.Add((51, 90), new MagicItemType(2, "Miscellaneous Weapons"));
        magicWeaponTypeDictionary.Add((91, 100), new MagicItemType(3, "Special Weapon"));
    }

    private void InitMagicSwordType()
    {
        if (magicSwordTypeDictionary != null) return;
        magicSwordTypeDictionary = new Dictionary<(int, int), MagicItemType>();

        magicSwordTypeDictionary.Add((1, 10), new MagicItemType(0, "Bastard Sword"));
        magicSwordTypeDictionary.Add((11, 30), new MagicItemType(1, "Broad Sword, Falchion"));
        magicSwordTypeDictionary.Add((31, 50), new MagicItemType(2, "Short Sword, Scimitar, Rapier"));
        magicSwordTypeDictionary.Add((51, 90), new MagicItemType(3, "Long Sword"));
        magicSwordTypeDictionary.Add((91, 100), new MagicItemType(4, "Two Handed Sword"));
    }

    private void InitSpecialSword()
    {
        if (specialSwordDictionary != null) return;
        specialSwordDictionary = new Dictionary<(int, int), MagicItem>();

        //TODO: delegate for +3 bane weapon roll
        specialSwordDictionary.Add((1, 8),  new MagicItem("Bane Sword", 13500, 4500, 
            "Normally +1 weapon but against designated foe a +3 weapon with extra 2d6 damage", 330, false, null, null, false, InitBaneWeapon()));
        specialSwordDictionary.Add((9, 16), new MagicItem("Sword of Dancing", 12500, 4100, "TODO", 331));
        specialSwordDictionary.Add((17, 24), new MagicItem("Sword of Defending +4", 24500, 8100, 
            "Allows the wielder to transfer all or any of the sword's magical bonus to AC. Any bonus transfered is not added to the attack roll", 331));
        specialSwordDictionary.Add((25, 32), new MagicItem("Dragon Slayer +2/+4", 29000, 7250,
            "Normally +2 weapon, but against dragons of the rolled type +4 BtH and double damage", 331, false, null, null, false, InitDragonType()));
        specialSwordDictionary.Add((33, 36), new MagicItem("Featheredged Sword", 31075, 15000,
    "+3 to hit and +1 to damage. A non modified roll of 18-20 severs a limb/hand/foot or head. Check table on page 331.", 331));
        specialSwordDictionary.Add((37, 44), new MagicItem("Flaming Sword +2", 7750, 2000,
    "+2 weapon. Deals +1d6 extra damage on hit, +2d6 extra damage on cold based creatures", 331));
        specialSwordDictionary.Add((45, 52), new MagicItem("Frostbane/Frostbrand +3", 13725, 3000,
"+3 icy weapon. Sheds light as a torch on 0F //TODO insert celcius temperature. 10 points of fire resistance each round. Deals double damage against fire-based creatures", 331));
        specialSwordDictionary.Add((53, 56), new MagicItem("Holy Avenger +2/+5", 55000, 27000,
"+2 weapon iron sword becomes +5 holy sword in the hands of a paladin. Deals double damage on targets of evil alignment. Provides bonus spell resistance equal to paladin's level + 5 to the wielder and anyone adjacent to her." +
"enables wielder to use dispel magic (once per round as a normal action) at the class level of the paladin. It inflicts 2d20 points of damage to any evil aligned creature that attempts to wield it", 331));
        specialSwordDictionary.Add((57, 60), new MagicItem("Sword of Life Stealing +2", 17000, 5600,
"+2 ebony iron sword. Upon natural 20 weapon drains a level from its victim and grants 1d6 temporary hitpoints to the wielder. These temporary hit points last one day. Victim who survives" +
"such a strike from a life stealer must make a CON save for each level lost. If successful, the level will return in 1d4 days or with a restoratio spell. If failed, the level is lost permanently and the victim's experience points are" +
"" +
"moved to the mid point of points requried for the previous level (as if struck by undead)", 331));
        specialSwordDictionary.Add((61, 68), new MagicItem("Luck Blade +2", 21500, 7100,
"Grants +1 luck bonus on all saves. The possessor gains the benefit of 'Good Fortune' usable once a day. The extraordinary ability allows any single roll to be re-rolled. Blade has a 5% chance to contain 1-3 wishes. When the last wish" +
"is used the sword retains all of its other abilities and properties.", 331));
        specialSwordDictionary.Add((69, 72), new MagicItem("Nine Lives Stealer +2", 8500, 2800,
"+2 Sword. On a natural 20 to hit, the victim of this blade must make a CON save (CL 2) or be struck dead. It can do this nine times before the ability is lost. At that point the sword becomes a simple +2 Sword (with a hint of evil about it)." +
"Any good creature who wields the sword suffers a -2 to their BtH. No spell can reverse this penalty. Only abjuring the weapon itself will negate the penalties.", 331));
        specialSwordDictionary.Add((73, 80), new MagicItem("Sword of Puncturing +2", 12000, 3000,
"+2 wounding sword allows the wielder to inflict 1d6 CON damage 3 times per day (by draining blood from its victim) with a successful hit.", 331));
        specialSwordDictionary.Add((81, 88), new MagicItem("Sylvan Sword +3", 10000, 3000,
"+3 blade whren used outdoors in a woodland climate, inflicts and additional 1d6 damage on a hit. If target is reduced to 0 hitpoints or less by a single strike, the wielder of the sword gains a free attack on another single target within melee range of the sword's wielder.", 331));
        specialSwordDictionary.Add((89, 92), new MagicItem("Vorpal Sword +4", 38750, 19000,
"+4 weapon. Has the unique ability to decapitate those it strikes. On a natural 20, the weapon severs the opponent's head (if it has one). Undeads, golems or headless creatures are not affected by decapitation. For vampires and most creatures, decapitation results in an instant death.", 331));
        specialSwordDictionary.Add((93, 100), new MagicItem("Sword of Wounding +3", 16000, 5300,
"Every time a creature is struck by this sword, in addition to normal damage the creature loses additional hit points from the blood loss equal to the maximum damage of the sword, including the +3 bonus." +
"For example a long sword of wounding inflicts 11 points of blood loss damage. The victim suffers 1 point of damage per round until 11 points of daamge are dealt or a healing spell is cast to stop the loss.", 332));
    }
    private void InitItemBonus()
    {
        if (itemBonusDictionary != null) return;
        itemBonusDictionary = new Dictionary<(int, int), ItemBonus>();

        itemBonusDictionary.Add((1, 45), new ItemBonus(1, 1000, 250));
        itemBonusDictionary.Add((46, 75), new ItemBonus(2, 4000, 750));
        itemBonusDictionary.Add((76, 90), new ItemBonus(3, 9000, 1200));
        itemBonusDictionary.Add((91, 98), new ItemBonus(4, 16000, 1750));
        itemBonusDictionary.Add((99, 100), new ItemBonus(5, 25000, 2500));
    }
    public void RollItemType(int itemsAmount)
    {
        InitMagicItems();
        for (int i = 0; i < itemsAmount; i++)
        {
            int roll = CommonUtils.RollPercentage();
            MagicItemType itemType = magicItemTypesDictionary.Where(x => roll >= x.Key.Item1 && roll <= x.Key.Item2).FirstOrDefault().Value;

            Console.WriteLine("\nRolled " + roll + " for magic item type which is " + itemType.subTableDescription + " and table index " + (itemType.subTableIndex + 1));

            switch (itemType.subTableIndex)
            {
                case 0:
                    RollPotions(InitPotions());
                    break;
                case 1:
                    RollScrolls(InitScrolls());
                    break;
                case 2:
                    RollWeapons();
                    break;
                /*
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
        */
                default:
                    RollWeapons();
                    //Console.WriteLine("\nSomething went wrong");
                    break;
            }
        }
    }

    private void RollPotions(Dictionary<(int, int), Item> dict)
    {
        CommonUtils.RollItemTable(dict, "Potions");
        /*
        InitPotions(); //Replace with a delegate?
        int roll = CommonUtils.RollPercentage();
        Item potionsEntry = potionsDictionary.Where(x => roll >= x.Key.Item1 && roll <= x.Key.Item2).FirstOrDefault().Value;
        Item potion = new Item(potionsEntry.name, potionsEntry.gp, potionsEntry.xp, potionsEntry.description, potionsEntry.pageNumber, potionsEntry.isRollValueTable, potionsEntry.rollGpValue);
        Console.WriteLine("Rolled " + roll + " for potion type which is... ");
        potion.PrintInfo();
        */
    }

    private void RollScrolls(Dictionary<(int, int), Item> dict)
    {
        CommonUtils.RollItemTable(dict, "Scrolls");
        /*
        InitScrolls(); //Replace with a delegate?
        int roll = CommonUtils.RollPercentage();
        Item scrollsEntry = scrollsDictionary.Where(x => roll >= x.Key.Item1 && roll <= x.Key.Item2).FirstOrDefault().Value;
        Item scroll = new Item(scrollsEntry.name, scrollsEntry.gp, scrollsEntry.xp, scrollsEntry.description, scrollsEntry.pageNumber, scrollsEntry.isRollValueTable, scrollsEntry.rollGpValue);
        Console.WriteLine("Rolled " + roll + " for scroll type which is... ");
        scroll.PrintInfo();
        */
    }

    private void RollWeapons()
    {
        InitMagicWeaponType();
        int roll = CommonUtils.RollPercentage();
        MagicItemType itemType = magicWeaponTypeDictionary.Where(x => roll >= x.Key.Item1 && roll <= x.Key.Item2).FirstOrDefault().Value;

        Console.WriteLine("\nRolled " + roll + " for magic weapon type which is " + itemType.subTableDescription + " and table index " + (itemType.subTableIndex + 1));

        switch (itemType.subTableIndex)
        {
            case 0:
                RollMagicSword(true);
                break;
            case 1:
                RollSpecialSword();
                break;
            /*
    case 2:
        RollMiscWeapon();
        break;
    case 3:
        RollSpecialMiscWeapon();
        break;*/
            default:
                RollSpecialSword();
                //Console.WriteLine("\nSomething went wrong");
                break;
        }
    }

    private string RollMagicSword(bool rollWeaponBonus)
    {
        InitMagicSwordType();
        int roll = CommonUtils.RollPercentage();
        MagicItemType swordsEntry = magicSwordTypeDictionary.Where(x => roll >= x.Key.Item1 && roll <= x.Key.Item2).FirstOrDefault().Value;
        MagicItem sword = new MagicItem(swordsEntry.subTableDescription, 0, 0, "", 0, false, null, null, true);
        if (rollWeaponBonus) sword.RollItemBonus(this);
        Console.WriteLine("Rolled " + roll + " for sword type which is... ");
        sword.PrintInfo();

        return swordsEntry.subTableDescription;
    }

    private void RollSpecialSword()
    {
        RollMagicSword(false);
        InitSpecialSword();

        int roll = CommonUtils.RollPercentage();
        MagicItem swordsEntry = specialSwordDictionary.Where(x => roll >= x.Key.Item1 && roll <= x.Key.Item2).FirstOrDefault().Value;
        MagicItem sword = new MagicItem(swordsEntry.name,swordsEntry.gp,swordsEntry.xp,swordsEntry.description, swordsEntry.pageNumber, swordsEntry.isRollValueTable, swordsEntry.rollGpValue, swordsEntry.rollAmount, swordsEntry.isRollItemBonus, swordsEntry.optionalTable);
        Console.WriteLine("Rolled " + roll + " for special sword type which is... ");
        sword.PrintInfo();
    }

    private void RollMiscWeapon()
    {

    }

    private void RollSpecialMiscWeapon()
    {

    }

    public ItemBonus RollItemBonus()
    {
        InitItemBonus();

        int roll = CommonUtils.RollPercentage();
        ItemBonus itemBonusEntry = itemBonusDictionary.Where(x => roll >= x.Key.Item1 && roll <= x.Key.Item2).FirstOrDefault().Value;
        Console.WriteLine("Rolled " + roll + " for item bonus entry which is: +" + itemBonusEntry.bonus.ToString());
        return itemBonusEntry;
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

    #region InitOptionalTables
    
    private Dictionary<(int,int), MagicItemType> InitBaneWeapon()
    {
        if (baneDictionary != null) return baneDictionary;
        baneDictionary = new Dictionary<(int, int), MagicItemType>();

        baneDictionary.Add((1, 1), new MagicItemType(0, "Undead"));
        baneDictionary.Add((2, 2), new MagicItemType(1, "Creatures able to cast spells"));
        baneDictionary.Add((3, 4), new MagicItemType(2, "Orc"));
        baneDictionary.Add((5, 6), new MagicItemType(3, "Goblin"));
        baneDictionary.Add((7, 8), new MagicItemType(4, "Giant"));
        baneDictionary.Add((9, 10), new MagicItemType(5, "Lycanthropes"));
        baneDictionary.Add((11, 11), new MagicItemType(6, "Demons/Devils"));
        baneDictionary.Add((12, 12), new MagicItemType(7, "Dragons"));

        return baneDictionary;
    }

    private Dictionary<(int, int), MagicItemType> InitDragonType()
    {
        if (dragonDictionary != null) return dragonDictionary;
        dragonDictionary = new Dictionary<(int, int), MagicItemType>();

        dragonDictionary.Add((1, 1), new MagicItemType(0, "Black"));
        dragonDictionary.Add((2, 2), new MagicItemType(1, "Blue"));
        dragonDictionary.Add((3, 3), new MagicItemType(2, "Green"));
        dragonDictionary.Add((4, 4), new MagicItemType(3, "Red"));
        dragonDictionary.Add((5, 5), new MagicItemType(4, "White"));
        dragonDictionary.Add((6, 6), new MagicItemType(5, "Brass"));
        dragonDictionary.Add((7, 7), new MagicItemType(6, "Bronze"));
        dragonDictionary.Add((8, 8), new MagicItemType(7, "Copper"));
        dragonDictionary.Add((9, 9), new MagicItemType(8, "Gold"));
        dragonDictionary.Add((10, 10), new MagicItemType(9, "Silver"));

        return dragonDictionary;
    }
    #endregion
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

    public struct MagicItemType
    {
        public int subTableIndex;
        public string subTableDescription;

        public MagicItemType(int subTableIndex, string subTableDescription)
        {
            this.subTableIndex = subTableIndex;
            this.subTableDescription = subTableDescription;
        }
    }

    private struct MagicItemContainer
    {
        public int subTableIndex;
        public string subTableDescription;
        public MagicItem magicItem;

        public MagicItemContainer(int subTableIndex, string subTableDescription, MagicItem magicItem)
        {
            this.subTableIndex = subTableIndex;
            this.subTableDescription = subTableDescription;
            this.magicItem = magicItem;
        }
    }

    public struct ItemBonus
    {
        public int bonus;
        public int gp;
        public int xp;

        public ItemBonus(int bonus, int gp, int xp)
        {
            this.bonus = bonus;
            this.gp = gp;
            this.xp = xp;
        }
    }
}

