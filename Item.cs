using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Item
{
    public string name;
    public int gpValue;
    public string description;
    public int pageNumber;
    public bool isRollValueTable;
    public ValueTable.ValueTableEntry material; //if ValueTable applies
    public Roll rollGpValue;
    public int amount = 1;
    private Roll rollAmount;
    //TODO: Store material for later use?
    //public ValueTable.ValueTableEntry material;

    public Item(string name, int gpValue, string description = "", int pageNumber = 0, bool isRollValueTable = false, Roll rollGpValue = null, Roll rollAmount = null)
    {
        this.name = name;
        this.gpValue = gpValue;
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
            material = ValueTable.RollValueTable(gpValue);
            gpValue += material.gpValue;
        }
    }

    public void RollGpValue()
    {
        if (rollGpValue == null) return;

        for (int i = 0; i < amount; i++)
        {
            int roll = rollGpValue.RollXdY();
            gpValue += roll;
        }
    }

    public void RollAmount()
    {
        if (this.rollAmount == null) return;

        this.amount = this.rollAmount.RollXdY();
    }

    public void PrintInfo()
    {
        Console.WriteLine("Name: " + name + " gp value: " + gpValue + " amount: " + amount);
        if (description != "") Console.WriteLine("Description: " + description);
        if (pageNumber != 0) Console.WriteLine("Page number: " + pageNumber);
        if (isRollValueTable) Console.WriteLine("Material: " + material.description);
    }
}
