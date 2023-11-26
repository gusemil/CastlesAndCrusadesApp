using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        bool mainLoop = true;
        Console.WriteLine("Hello Castle Keeper!");
        while (mainLoop)
        {
            Console.WriteLine("Do you want to choose or roll treasure level? C/R");
            int treasureLevel;
            ConsoleKeyInfo input = Console.ReadKey();
            if (input.Key == ConsoleKey.C)
            {
                Console.WriteLine("Choose a number between 1-18");
                string treasureLevelInput = Console.ReadLine();
                int treasureLevelInputInt = Convert.ToInt32(treasureLevelInput);
                if (treasureLevelInputInt > 0 && treasureLevelInputInt <= 18)
                {
                    treasureLevel = treasureLevelInputInt;
                    RollTreasure(treasureLevel);
                }
                else
                {
                    InvalidInput();
                }
            }
            else if (input.Key == ConsoleKey.R)
            {
                Console.WriteLine("Vittu");
                treasureLevel = RollNumber(1, 18);
                RollTreasure(treasureLevel);
            }
            else
            {
                InvalidInput();
            }

            //End
            Console.WriteLine("Do you wish to end the application? Y/N");
            if (Console.ReadKey().Key == ConsoleKey.Y) { break; }
        }
    }

    #region General Methods
    public static void InvalidInput()
    {
        Console.WriteLine("Invalid input. Please try again");
    }

    public static int RollNumber(int min, int max, int modifier = 0)
    {
        Random rnd = new Random();
        int roll = rnd.Next(min, max);
        if (modifier > 0)
        {
            roll += modifier;
        }
        Console.WriteLine("Rolling " + min + "-" + max + " + modifier: " + modifier + " Result: " + roll);

        return roll;
    }

    /*
    public static int RollXdY(int x, int y, int modifier = 0, int multiplier = 0)
    {
        int roll = 0;
        Random rnd = new Random();
        for (int i = 0; i < x; i++)
        {
            roll += rnd.Next(1, y);
        }

        if (modifier > 0)
        {
            roll += modifier;
        }

        if(multiplier > 0)
        {
            roll *= multiplier;
        }

        return roll;
    }
    */

    public static int RollPercentage()
    {
        Random rnd = new Random();
        int roll = rnd.Next(1, 100);
        return roll;
    }

    public static bool RollPercentageSuccess(int percentageChance)
    {
        bool result = true;
        int roll = RollPercentage();
        if (percentageChance > 0 && roll > percentageChance)
        {
            result = false;
        }
        return result;
    }
    #endregion

    //Main Rolls
    #region MainTreasureRolls
    private static void RollTreasure(int treasureLevel)
    {
        RollCoins(treasureLevel);
        //RollGems(treasureLevel);
        //RollExtraOrdinaryItems(treasureLevel);
        //RollMagicItems(treasureLevel);
    }

    private static void RollCoins(int treasureLevel)
    {
        Coins newCoins = new Coins();
        int coinsDictIndex = treasureLevel - 1;
        int chanceToHaveCoins = newCoins.coinsDictionary[coinsDictIndex].percentageChance;
        bool hasCoins = RollPercentageSuccess(chanceToHaveCoins);
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

    }
    private static void RollMagicItems(int treasureLevel)
    {

    }

    private static void RollExtraOrdinaryItems(int treasureLevel)
    {

    }
    #endregion
}
