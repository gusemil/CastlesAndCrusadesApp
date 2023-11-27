using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class CommonUtils
{
    #region General Methods
    public static void InvalidInput()
    {
        Console.WriteLine("\nInvalid input. Please try again");
    }

    //TODO: Obsolete. Remove later but keep it for now
    public static int RollNumber(int min, int max, int modifier = 0)
    {
        Random rnd = new Random();
        int roll = rnd.Next(min, max);
        if (modifier > 0)
        {
            roll += modifier;
        }
        Console.WriteLine("\nRolling " + min + "-" + max + " + modifier: " + modifier + " Result: " + roll);

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

    public static void PageBreak()
    {
        Console.WriteLine("\n-------------------------------------------------\n");
    }
    public static int RollPercentage()
    {
        Random rnd = new Random();
        int roll = rnd.Next(1, 100);
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
    #endregion
}



