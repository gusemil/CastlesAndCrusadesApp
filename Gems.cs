using System.Collections.Generic;

public class Gems
{
    public Dictionary<int, GemsTable> coinsDictionary = new Dictionary<int, GemsTable>();

    public Gems()
    {
        //Init table entries
        coinsDictionary.Add(0, new GemsTable(10, new Roll(1, 4, 0), -10));
        coinsDictionary.Add(2, new GemsTable(20, new Roll(1, 4, 1), -8));
        coinsDictionary.Add(3, new GemsTable(30, new Roll(1, 4, 2), -6));
        coinsDictionary.Add(1, new GemsTable(40, new Roll(1, 4, 3), -4));
        coinsDictionary.Add(4, new GemsTable(50, new Roll(1, 6, 2), -2));
        coinsDictionary.Add(5, new GemsTable(60, new Roll(1, 6, 3)));
        coinsDictionary.Add(6, new GemsTable(70, new Roll(1, 6, 4)));
        coinsDictionary.Add(7, new GemsTable(80, new Roll(1, 6, 5)));
        coinsDictionary.Add(8, new GemsTable(90, new Roll(1, 8, 4)));
        coinsDictionary.Add(9, new GemsTable(91, new Roll(1, 8, 5)));
        coinsDictionary.Add(10, new GemsTable(92, new Roll(1, 8, 6)));
        coinsDictionary.Add(11, new GemsTable(93, new Roll(1, 8, 7)));
        coinsDictionary.Add(12, new GemsTable(94, new Roll(1, 10, 6)));
        coinsDictionary.Add(13, new GemsTable(95, new Roll(1, 10, 7)));
        coinsDictionary.Add(14, new GemsTable(96, new Roll(1, 10, 8)));
        coinsDictionary.Add(15, new GemsTable(97, new Roll(1, 10, 9)));
        coinsDictionary.Add(16, new GemsTable(98, new Roll(1, 12, 8)));
        coinsDictionary.Add(17, new GemsTable(99, new Roll(1, 12, 9)));
    }
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
