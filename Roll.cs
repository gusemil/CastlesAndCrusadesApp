using System;
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
        int unadjustedRoll = 0;
        Random rnd = CommonUtils.RandomInstance;
        for (int i = 0; i < x; i++)
        {
            roll += rnd.Next(1, y);
        }

        unadjustedRoll = roll;

        if (modifier > 0)
        {
            roll += modifier;
        }

        if (roll < 0) roll = 0;

        if (multiplier > 0 && roll != 0)
        {
            roll *= multiplier;
        }

        Console.WriteLine("Rolling " + x + "d" + y + " results in " + unadjustedRoll + " adding modifier " + modifier +
            " and multiplier " + multiplier + " Result: " + roll);

        return roll;
    }
}
