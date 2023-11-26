using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Roll
{
    private int x;
    private int y;
    private int modifier;
    private int multiplier;
    public Roll(int x, int y, int modifier = 0, int multiplier = 0)
    {
        this.x = x;
        this.y = y;
        this.modifier = modifier;
        this.multiplier = multiplier;
    }

    public int RollXdY()
    {
        int roll = 0;
        Random rnd = new Random();
        for (int i = 0; i < x; i++)
        {
            roll += rnd.Next(1, y);
        }

        if (modifier > 0)
        {
            roll += modifier;
        }

        if (multiplier > 0)
        {
            roll *= multiplier;
        }

        return roll;
    }
}
