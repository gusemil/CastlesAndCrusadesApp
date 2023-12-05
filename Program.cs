using System;
public class Program
{
    private static Gems gems = new Gems();
    private static ExtraOrdinaryItems extraOrdinaryItems = new ExtraOrdinaryItems();
    private static MagicItems magicItems = new MagicItems();
    static void Main(string[] args)
    {
        CommonUtils.InitRandom();
        bool mainLoop = true;
        bool reroll = true;
        int treasureLevel = 0;
        const int MAX_TREASURE_LEVEL = 18;
        Console.WriteLine("Welcome, Castle Keeper!");
        while (mainLoop)
        {
            Console.WriteLine("\n\nDo you want to choose or roll treasure level? C/R");
            ConsoleKeyInfo input = Console.ReadKey();
            if (input.Key == ConsoleKey.C)
            {
                Console.WriteLine("\nChoose a number between 1-18");
                string treasureLevelInput = Console.ReadLine();
                int treasureLevelInputInt = Convert.ToInt32(treasureLevelInput);
                if (treasureLevelInputInt > 0 && treasureLevelInputInt <= MAX_TREASURE_LEVEL)
                {
                    treasureLevel = treasureLevelInputInt;
                    RollTreasure(treasureLevel);
                }
                else
                {
                    CommonUtils.InvalidInput();
                }
            }
            else if (input.Key == ConsoleKey.R)
            {
                treasureLevel = CommonUtils.RollNumber(1, MAX_TREASURE_LEVEL);
                RollTreasure(treasureLevel);
            }
            else
            {
                CommonUtils.InvalidInput();
            }

            //Reroll
            reroll = true;
            while (reroll)
            {
                Console.WriteLine("\nDo you wish to reroll? R/any key to exit");
                if (Console.ReadKey().Key == ConsoleKey.R)
                {
                    RollTreasure(treasureLevel);
                }
                else
                {
                    reroll = false;
                }
            }

            //End
            Console.WriteLine("\nDo you wish to end the application? Y/N");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.WriteLine("");
                break;
            }
        }
    }

    //Main Rolls
    #region MainTreasureRolls
    private static void RollTreasure(int treasureLevel)
    {
        RollCoins(treasureLevel);
        RollGems(treasureLevel);
        RollExtraOrdinaryItems(treasureLevel);
        RollMagicItems(treasureLevel);
    }

    private static void RollCoins(int treasureLevel)
    {
        CommonUtils.PageBreak();
        Coins newCoins = new Coins();
        int coinsDictIndex = treasureLevel - 1;
        int chanceToHaveCoins = newCoins.coinsDictionary[coinsDictIndex].percentageChance;
        bool hasCoins = CommonUtils.RollPercentageSuccess(chanceToHaveCoins);
        Console.WriteLine(chanceToHaveCoins + "% chance of the treasure containing gold coins. Your result: " + hasCoins);
        int coins = 0;
        if (hasCoins)
        {
            coins = newCoins.coinsDictionary[coinsDictIndex].coinsRoll.RollXdY();
        }
        Console.WriteLine("The treasure with treasure level " + treasureLevel + " contains " + coins + " gold pieces");
    }

    private static void RollGems(int treasureLevel)
    {
        CommonUtils.PageBreak();
        int gemsDictIndex = treasureLevel - 1;
        int chanceToHaveGems = gems.gemsDictionary[gemsDictIndex].percentageChance;
        bool hasGems = CommonUtils.RollPercentageSuccess(chanceToHaveGems);
        Console.WriteLine(chanceToHaveGems + "% chance of the treasure containing gems. Your result: " + hasGems);
        int gemsAmount = 0;
        if (hasGems)
        {
            gems.InitGemsSubtable();
            gemsAmount = gems.gemsDictionary[gemsDictIndex].gemsRoll.RollXdY();
        }
        Console.WriteLine("The treasure with treasure level " + treasureLevel + " contains " + gemsAmount + " gems");

        if (hasGems)
        {
            Console.WriteLine("Rolling gem subtable for " + gemsAmount + " gems");
            gems.RollGemsSubTable(gemsAmount);
        }

    }

    private static void RollExtraOrdinaryItems(int treasureLevel)
    {
        CommonUtils.PageBreak();
        int extraOrdinaryItemsDictIndex = treasureLevel - 1;
        int chanceToHaveItems = extraOrdinaryItems.extraOrdinaryItemsDictionary[extraOrdinaryItemsDictIndex].percentageChance;
        bool hasItems = CommonUtils.RollPercentageSuccess(chanceToHaveItems);
        int itemsAmount = 0;
        if (hasItems)
        {
            Console.WriteLine("The treasure with treasure level " + treasureLevel + " contains " + itemsAmount + " extraordinary item");
            itemsAmount = extraOrdinaryItems.extraOrdinaryItemsDictionary[extraOrdinaryItemsDictIndex].itemsRoll.RollXdY();
            Console.Write("Rolling extraordinary item type for " + itemsAmount + " items");
            extraOrdinaryItems.RollItemType(itemsAmount);
        }
    }

    private static void RollMagicItems(int treasureLevel)
    {
        CommonUtils.PageBreak();
        int magicItemsDictIndex = treasureLevel - 1;
        int chanceToHaveItems = magicItems.magicItemsDictionary[magicItemsDictIndex].percentageChance;
        bool hasItems = CommonUtils.RollPercentageSuccess(chanceToHaveItems);
        Console.WriteLine(chanceToHaveItems + "% chance of the treasure containing magic items. Your result: " + hasItems);
        int itemsAmount = 0;
        if (hasItems)
        {
            itemsAmount = magicItems.magicItemsDictionary[magicItemsDictIndex].itemTypeRoll.RollXdY();
            Console.WriteLine("The treasure with treasure level " + treasureLevel + " contains " + itemsAmount + " magic items");
            Console.Write("Rolling magic item type for " + itemsAmount + " items");
            magicItems.RollItemType(itemsAmount);
        }
    }
    #endregion

    #region SubTables

    #endregion
}