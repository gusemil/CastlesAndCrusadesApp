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

    public Item(string name, int gpValue, string description = "", int pageNumber = 0)
    {
        this.name = name;
        this.gpValue = gpValue;
        this.description = description;
        this.pageNumber = pageNumber;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Name: " + name + " gp value: " + gpValue);
        if (description != "") Console.WriteLine("Description: " + description);
        if (pageNumber != 0) Console.WriteLine("Page number: " + pageNumber);
    }
}
