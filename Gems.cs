using System.Collections.Generic;
using System.Linq;
using System;

public class Gems
{
    public Dictionary<int, GemsTable> gemsDictionary = new Dictionary<int, GemsTable>();
    private Dictionary<(int, int), GemsSubTable> gemsSubtableDictionary = new Dictionary<(int, int), GemsSubTable>();

    public Gems()
    {
        //Init table entries
        gemsDictionary.Add(0, new GemsTable(10, new Roll(1, 4, 0), -10));
        gemsDictionary.Add(1, new GemsTable(20, new Roll(1, 4, 1), -8));
        gemsDictionary.Add(2, new GemsTable(30, new Roll(1, 4, 2), -6));
        gemsDictionary.Add(3, new GemsTable(40, new Roll(1, 4, 3), -4));
        gemsDictionary.Add(4, new GemsTable(50, new Roll(1, 6, 2), -2));
        gemsDictionary.Add(5, new GemsTable(60, new Roll(1, 6, 3)));
        gemsDictionary.Add(6, new GemsTable(70, new Roll(1, 6, 4)));
        gemsDictionary.Add(7, new GemsTable(80, new Roll(1, 6, 5)));
        gemsDictionary.Add(8, new GemsTable(90, new Roll(1, 8, 4)));
        gemsDictionary.Add(9, new GemsTable(91, new Roll(1, 8, 5)));
        gemsDictionary.Add(10, new GemsTable(92, new Roll(1, 8, 6)));
        gemsDictionary.Add(11, new GemsTable(93, new Roll(1, 8, 7)));
        gemsDictionary.Add(12, new GemsTable(94, new Roll(1, 10, 6)));
        gemsDictionary.Add(13, new GemsTable(95, new Roll(1, 10, 7)));
        gemsDictionary.Add(14, new GemsTable(96, new Roll(1, 10, 8)));
        gemsDictionary.Add(15, new GemsTable(97, new Roll(1, 10, 9)));
        gemsDictionary.Add(16, new GemsTable(98, new Roll(1, 12, 8)));
        gemsDictionary.Add(17, new GemsTable(99, new Roll(1, 12, 9)));
    }

    public void InitGemsSubtable()
    {
        gemsSubtableDictionary.Add((1, 10), new GemsSubTable("'Amber, amethyst, jadeite'", 5));
        gemsSubtableDictionary.Add((11, 20), new GemsSubTable("'Precious opal, banded eye, malachite'", 10));
        gemsSubtableDictionary.Add((21, 40), new GemsSubTable("'Moonstone, pearl, lapis lazuli, tiger eye'", 25));
        gemsSubtableDictionary.Add((41, 60), new GemsSubTable("'Bloodstone, white agate, violet-blue sapphire'", 50));
        gemsSubtableDictionary.Add((61, 75), new GemsSubTable("'Whitish moonstone, common opal'", 100));
        gemsSubtableDictionary.Add((76, 85), new GemsSubTable("'Green nephrite, peridot, amethyst'", 250));
        gemsSubtableDictionary.Add((86, 90), new GemsSubTable("'Violet or green garnet, fire opal, topaz'", 500));
        gemsSubtableDictionary.Add((91, 94), new GemsSubTable("'Emerald, black opal, tourmaline'", 1000));
        gemsSubtableDictionary.Add((95, 98), new GemsSubTable("'Star ruby, sapphire (other than blue'", 2500));
        gemsSubtableDictionary.Add((99, 100), new GemsSubTable("'Diamond, blood red ruby, blue sapphire'", 5000));
    }

    public void RollGemsSubTable(int gemAmount, int gemValueAdjustment = 0)
    {
        int percentageRoll = CommonUtils.RollPercentage() + gemValueAdjustment;
        if (percentageRoll < 1) percentageRoll = 1;
        GemsSubTable subTableEntry =
            gemsSubtableDictionary.Where(x => percentageRoll >= x.Key.Item1 && percentageRoll <= x.Key.Item2).FirstOrDefault().Value;

        Console.WriteLine(subTableEntry.description + " gems have a gold piece value of " + subTableEntry.gpValue
            + " per gem. Total value of " + gemAmount + " such gems is " + gemAmount * subTableEntry.gpValue + " gold pieces");
    }

    public struct GemsTable
    {
        public int percentageChance;
        public Roll gemsRoll;
        public int gemValueAdjustment;

        public GemsTable(int percentageChance, Roll gemsRoll, int gemValueAdjustment = 0)
        {
            this.percentageChance = percentageChance;
            this.gemsRoll = gemsRoll;
            this.gemValueAdjustment = gemValueAdjustment;
        }
    }

    private struct GemsSubTable
    {
        public string description;
        public int gpValue;

        public GemsSubTable(string description, int gpValue)
        {
            this.description = description;
            this.gpValue = gpValue;
        }
    }
}