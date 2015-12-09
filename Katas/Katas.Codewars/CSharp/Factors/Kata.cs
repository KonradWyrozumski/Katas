using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] Factors(int num)
    {
        if (num < 1)
        {
            return new int[] { };
        }

        var factors = new List<int>();

        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                factors.Add(i);
            }
        }

        return factors.OrderByDescending(x => x).ToArray();
    }
}