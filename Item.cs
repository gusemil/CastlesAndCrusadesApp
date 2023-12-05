using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Item
{
    public string name;
    public int gp;
    public int xp;
    public string description;
    public int pageNumber;
    public bool isRollValueTable;
    public ValueTable.ValueTableEntry material; //if ValueTable applies
    public Roll rollGpValue;
    public int amount = 1;
    private Roll rollAmount;

    public Item(string name, int gpValue, int xp = 0, string description = "", int pageNumber = 0, bool isRollValueTable = false, Roll rollGpValue = null, Roll rollAmount = null)
    {
        this.name = name;
        this.gp = gpValue;
        this.xp = xp;
        this.description = description;
        this.pageNumber = pageNumber;
        this.isRollValueTable = isRollValueTable;
        this.rollGpValue = rollGpValue;
        this.rollAmount = rollAmount;
    }

    public void RollValueTable()
    {
        if (isRollValueTable)
        {
            material = ValueTable.RollValueTable(gp);
            gp += material.gpValue;
        }
    }

    public void RollGpValue()
    {
        if (rollGpValue == null) return;

        for (int i = 0; i < amount; i++)
        {
            int roll = rollGpValue.RollXdY();
            gp += roll;
        }
    }

    public void RollAmount()
    {
        //TODO: Bug with amount fix later...
        if (this.rollAmount == null) return;

        this.amount = this.rollAmount.RollXdY();
    }

    public void PrintInfo()
    {
        Console.WriteLine("Name: " + name + " gp value: " + gp + " amount: " + amount + " xp: " + xp);
        if (description != "") Console.WriteLine("Description: " + description);
        if (pageNumber != 0) Console.WriteLine("Page number: " + pageNumber);
        if (isRollValueTable) Console.WriteLine("Material: " + material.description);
    }
}
