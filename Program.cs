using System;
public class Program
{
    private static Gems gems = new Gems();
    private static ExtraOrdinaryItems extraOrdinaryItems = new ExtraOrdinaryItems();
    static void Main(string[] args)
    {
        CommonUtils.InitRandom();
        bool mainLoop = true;
        Console.WriteLine("Welcome, Castle Keeper!");
        while (mainLoop)
        {
            Console.WriteLine("\n\nDo you want to choose or roll treasure level? C/R");
            int treasureLevel;
            ConsoleKeyInfo input = Console.ReadKey();
            if (input.Key == ConsoleKey.C)
            {
                Console.WriteLine("\nChoose a number between 1-18");
                string treasureLevelInput = Console.ReadLine();
                int treasureLevelInputInt = Convert.ToInt32(treasureLevelInput);
                if (treasureLevelInputInt > 0 && treasureLevelInputInt <= 18)
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
                treasureLevel = CommonUtils.RollNumber(1, 18);
                RollTreasure(treasureLevel);
            }
            else
            {
                CommonUtils.InvalidInput();
            }

            //End
            Console.WriteLine("Do you wish to end the application? Y/N");
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
        //RollMagicItems(treasureLevel);
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
        int chanceToHaveGems = extraOrdinaryItems.extraOrdinaryItemsDictionary[extraOrdinaryItemsDictIndex].percentageChance;
        bool hasItems = CommonUtils.RollPercentageSuccess(chanceToHaveGems);
        Console.WriteLine(chanceToHaveGems + "% chance of the treasure containing extraordinary items. Your result: " + hasItems);
        int itemsAmount = 0;
        Console.WriteLine("The treasure with treasure level " + treasureLevel + " contains " + itemsAmount + " extraordinary item");
        if (hasItems)
        {
            Console.Write("Rolling extraordinary item type for " + itemsAmount + " items");
            itemsAmount = extraOrdinaryItems.extraOrdinaryItemsDictionary[extraOrdinaryItemsDictIndex].itemsRoll.RollXdY();
            extraOrdinaryItems.RollItemType(itemsAmount);
        }
    }

    private static void RollMagicItems(int treasureLevel)
    {

    }
    #endregion

    #region SubTables

    #endregion
}