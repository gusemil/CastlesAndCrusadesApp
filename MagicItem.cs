using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MagicItem : Item
{
    private MagicItems.ItemBonus itemBonus;
    public bool isRollItemBonus;
    public MagicItem(string name, int gpValue, int xp = 0, string description = "", int pageNumber = 0, bool isRollValueTable = false, Roll rollGpValue = null, Roll rollAmount = null, bool isRollItemBonus = false)
        : base(name, gpValue, xp, description, pageNumber, isRollValueTable, rollGpValue, rollAmount)
    {
        this.isRollItemBonus = isRollItemBonus;
    }

    public void RollItemBonus(MagicItems magicItem)
    {
        if (!isRollItemBonus) return;

        itemBonus = magicItem.RollItemBonus();
        gp += itemBonus.gp;
        xp += itemBonus.xp;
        description += "Bonus: " + itemBonus.bonus.ToString();
    }
}
