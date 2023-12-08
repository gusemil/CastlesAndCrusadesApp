using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class CommonUtils
{
    private static Random randomInstance = null;

    public static void InitRandom()
    {
        if(RandomInstance == null) RandomInstance = new Random();
    }

    public static void InvalidInput()
    {
        Console.WriteLine("\nInvalid input. Please try again");
    }

    public static int RollNumber(int min, int max, int modifier = 0)
    {
        Random rnd = RandomInstance;
        int roll = rnd.Next(min, (max +1)); //+1 to include maximum
        if (modifier > 0)
        {
            roll += modifier;
        }
        Console.WriteLine("\nRolling " + min + "-" + max + " + modifier: " + modifier + " Result: " + roll);

        return roll;
    }

    public static void PageBreak()
    {
        Console.WriteLine("\n-------------------------------------------------\n");
    }
    public static int RollPercentage()
    {
        Random rnd = RandomInstance;
        int roll = rnd.Next(1, (100 +1)); //+1 to include maximum
        Console.WriteLine("Percentage roll: " + roll);
        return roll;
    }

    public static bool RollPercentageSuccess(int percentageChance)
    {
        bool result = false;
        int roll = RollPercentage();
        if (percentageChance > 0 && roll <= percentageChance)
        {
            result = true;
        }
        return result;
    }

    public static void RollItemTable(Dictionary<(int, int), Item> dict, string itemType)
    {
        int roll = CommonUtils.RollPercentage();
        Item dictEntry = dict.Where(x => roll >= x.Key.Item1 && roll <= x.Key.Item2).FirstOrDefault().Value;
        Item item = new Item(dictEntry.name, dictEntry.gp, dictEntry.xp, dictEntry.description, dictEntry.pageNumber, dictEntry.isRollValueTable, dictEntry.rollGpValue, dictEntry.rollAmount);
        Console.WriteLine("Rolled " + roll + " for " + itemType + "which is... ");
        item.RollAmount();
        item.RollGpValue();
        item.RollValueTable();
        item.PrintInfo();
    }

    //TODO find item from dictionary method
    public static Random RandomInstance { get => randomInstance; private set => randomInstance = value; }
}



