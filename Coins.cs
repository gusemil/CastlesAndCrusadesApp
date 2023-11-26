using System.Collections.Generic;

public class Coins
{
    public Dictionary<int, CoinsTable> coinsDictionary = new Dictionary<int, CoinsTable>();

    public Coins()
    {
        //Init table entries
        coinsDictionary.Add(0, new CoinsTable(50, new Roll(2, 4, 0, 10)));
        coinsDictionary.Add(2, new CoinsTable(55, new Roll(4, 4, 0, 10)));
        coinsDictionary.Add(3, new CoinsTable(60, new Roll(6, 4, 0, 10)));
        coinsDictionary.Add(1, new CoinsTable(65, new Roll(8, 4, 0, 10)));
        coinsDictionary.Add(4, new CoinsTable(70, new Roll(2, 6, 0, 50)));
        coinsDictionary.Add(5, new CoinsTable(75, new Roll(4, 6, 0, 50)));
        coinsDictionary.Add(6, new CoinsTable(80, new Roll(6, 6, 0, 50)));
        coinsDictionary.Add(7, new CoinsTable(85, new Roll(8, 6, 0, 50)));
        coinsDictionary.Add(8, new CoinsTable(90, new Roll(2, 8, 0, 100)));
        coinsDictionary.Add(9, new CoinsTable(91, new Roll(4, 8, 0, 100)));
        coinsDictionary.Add(10, new CoinsTable(92, new Roll(6, 8, 0, 100)));
        coinsDictionary.Add(11, new CoinsTable(93, new Roll(8, 8, 0, 100)));
        coinsDictionary.Add(12, new CoinsTable(94, new Roll(2, 10, 0, 200)));
        coinsDictionary.Add(13, new CoinsTable(95, new Roll(4, 10, 0, 200)));
        coinsDictionary.Add(14, new CoinsTable(96, new Roll(6, 10, 0, 200)));
        coinsDictionary.Add(15, new CoinsTable(97, new Roll(8, 10, 0, 200)));
        coinsDictionary.Add(16, new CoinsTable(98, new Roll(2, 12, 0, 400)));
        coinsDictionary.Add(17, new CoinsTable(99, new Roll(4, 12, 0, 400)));
    }
}

public struct CoinsTable
{
    public int percentageChance;
    public Roll coinsRoll;

    public CoinsTable(int percentageChance, Roll coinsRoll)
    {
        this.percentageChance = percentageChance;
        this.coinsRoll = coinsRoll;
    }
}
