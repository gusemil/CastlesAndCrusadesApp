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
            Console.WriteLine("Do you want to choose or roll treasure level? Y/N?");
            int treasureLevel;
            ConsoleKeyInfo input = Console.ReadKey();
            if (input.Key == ConsoleKey.Y)
            {
                Console.WriteLine("Choose a number between 1-18");
                string treasureLevelInput = Console.ReadLine();
                int treasureLevelInputInt = Convert.ToInt32(treasureLevelInput);
                if (treasureLevelInputInt > 0 && treasureLevelInputInt <= 18)
                {
                    treasureLevel = treasureLevelInputInt;
                }
                else
                {
                    InvalidInput();
                }

            }
            else if (input.Key == ConsoleKey.N)
            {
                Console.WriteLine("Vittu");
                treasureLevel = RollNumber(1,18);
            }
            else
            {
                InvalidInput();
            }

            //End
            Console.WriteLine("Do you wish to end the program? Y/N");
            if(Console.ReadKey().Key == ConsoleKey.Y) { break; }
        }
    }

    public static void InvalidInput()
    {
        Console.WriteLine("Invalid input. Please try again");
    }

    public static int RollNumber(int min, int max)
    {
        Random rnd = new Random();
        int roll = rnd.Next(min, max);
        Console.WriteLine("Rolling " + min + "-" + max + " Result: " + roll);
        return roll;
    }
}
