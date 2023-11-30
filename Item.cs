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
    //TODO: Store material for later use?
    //public ValueTable.ValueTableEntry material;

    public Item(string name, int gpValue, string description = "", int pageNumber = 0, bool rollValueTable = false, Roll rollGpValue = null)
    {
        this.name = name;
        this.gpValue = gpValue;
        this.description = description;
        this.pageNumber = pageNumber;
        this.isRollValueTable = rollValueTable;
        this.rollGpValue = rollGpValue;
    }

    public void RollValueTable()
    {
        if (this.isRollValueTable)
        {
            this.material = ValueTable.RollValueTable(this.gpValue);
            gpValue += this.material.gpValue;
        }
    }

    public void RollGpValue()
    {
        if (rollGpValue == null) return;
        int roll = this.rollGpValue.RollXdY();
        this.gpValue += roll;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Name: " + name + " gp value: " + gpValue);
        if (description != "") Console.WriteLine("Description: " + description);
        if (pageNumber != 0) Console.WriteLine("Page number: " + pageNumber);
        if (isRollValueTable) Console.WriteLine("Material: " + this.material.description);
    }
}
