using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class ValueTable
{
    private static Dictionary<(int, int), ValueTableEntry> valueTableDictionary = null;

    public static void InitValueTable()
    {
        if(valueTableDictionary != null) return;
        valueTableDictionary = new Dictionary<(int, int), ValueTableEntry>();
        valueTableDictionary.Add((1, 2), new ValueTableEntry("'Clay'",10));
        valueTableDictionary.Add((3, 8), new ValueTableEntry("'Wood'",50));
        valueTableDictionary.Add((9, 11), new ValueTableEntry("'Wood with silver inlay'",100));
        valueTableDictionary.Add((12,13), new ValueTableEntry("'Wood with gold inlay'",250));
        valueTableDictionary.Add((14, 14), new ValueTableEntry("'Wood with gemstones'",500));
        valueTableDictionary.Add((15, 19), new ValueTableEntry("'Stone'",100));
        valueTableDictionary.Add((20, 23), new ValueTableEntry("'Stone with gemstones'",500));
        valueTableDictionary.Add((24, 24), new ValueTableEntry("'Bone with jewels'",1000));
        valueTableDictionary.Add((25, 34), new ValueTableEntry("'Silver'",250));
        valueTableDictionary.Add((35, 39), new ValueTableEntry("'Silver with gold'",500));
        valueTableDictionary.Add((40, 44), new ValueTableEntry("'Silver with platinum'",750));
        valueTableDictionary.Add((45, 50), new ValueTableEntry("'Silver with gemstones'",1250));
        valueTableDictionary.Add((51, 53), new ValueTableEntry("'Ivory'",500));
        valueTableDictionary.Add((54, 56), new ValueTableEntry("'Ivory with silver'",750));
        valueTableDictionary.Add((57, 58), new ValueTableEntry("'Ivory with gold'",1000));
        valueTableDictionary.Add((59, 60), new ValueTableEntry("'Ivory with gemstones'",3000));
        valueTableDictionary.Add((61, 63), new ValueTableEntry("'Jade (or other precious stone)'",750));
        valueTableDictionary.Add((64, 67), new ValueTableEntry("'Jade (or other precious stone) with ivory'",1000));
        valueTableDictionary.Add((68, 70), new ValueTableEntry("'Jade (or other precious stone) with silver or gold'",1250));
        valueTableDictionary.Add((71, 72), new ValueTableEntry("'Jade (or other precious stone) with platinum'",2000));
        valueTableDictionary.Add((73, 74), new ValueTableEntry("'Jade (or other precious stone) with gemstones'",5000));
        valueTableDictionary.Add((75, 86), new ValueTableEntry("'Gold'",1000));
        valueTableDictionary.Add((87, 89), new ValueTableEntry("'Gold wtih platinum'",3500));
        valueTableDictionary.Add((90, 93), new ValueTableEntry("'Gold with gemstones'",7500));
        valueTableDictionary.Add((94, 96), new ValueTableEntry("'Platinum'",10000));
        valueTableDictionary.Add((97, 98), new ValueTableEntry("'Platinum with gemstones'",15000));
        valueTableDictionary.Add((99, 99), new ValueTableEntry("'Platinum with mithril'",20000));
        valueTableDictionary.Add((100, 100), new ValueTableEntry("'Mithril'",50000));
    }

    public static void RollValueTable()
    {
        //TODO:
    }

    private struct ValueTableEntry
    {
        public string description;
        public int gpValue;

        public ValueTableEntry(string description, int gpValue)
        {
            this.description = description;
            this.gpValue = gpValue;
        }
    }

}
