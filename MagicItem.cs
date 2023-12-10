using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MagicItem : Item
{
    private MagicItems.ItemBonus itemBonus;
    public bool isRollItemBonus;
    public Dictionary<(int, int), MagicItems.MagicItemType> optionalTable;
    public MagicItem(string name, int gpValue, int xp = 0, string description = "", int pageNumber = 0, bool isRollValueTable = false, Roll rollGpValue = null, Roll rollAmount = null, bool isRollItemBonus = false, Dictionary<(int,int), MagicItems.MagicItemType> optionalTable = null)
        : base(name, gpValue, xp, description, pageNumber, isRollValueTable, rollGpValue, rollAmount)
    {
        this.isRollItemBonus = isRollItemBonus;
        this.optionalTable = optionalTable;
    }

    public void RollItemBonus(MagicItems magicItem)
    {
        if (!isRollItemBonus) return;

        itemBonus = magicItem.RollItemBonus();
        gp += itemBonus.gp;
        xp += itemBonus.xp;
        description += "Bonus: +" + itemBonus.bonus.ToString();
    }

    //TODO: decouple from magicItem?
    public void RollOptionalTable(Roll rollXdY = null, bool rollPercentage = false)
    {
        if (optionalTable == null) return;

        int roll = 0;
        if(rollXdY != null)
        {
            roll = rollXdY.RollXdY();
        }
        else if (rollPercentage)
        {
            roll = CommonUtils.RollPercentage();
        }
        else
        {
            Console.WriteLine("Something wrong with optional table parameters");
            return;
        }

        MagicItems.MagicItemType entry = optionalTable.Where(x => roll >= x.Key.Item1 && roll <= x.Key.Item2).FirstOrDefault().Value;
        Console.WriteLine("Rolled " + roll + " which is" + entry.subTableDescription);
    }
}
