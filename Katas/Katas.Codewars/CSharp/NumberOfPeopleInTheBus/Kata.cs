
using System;
using System.Collections.Generic;
using System.Linq;

public class NumberOfPeopleInTheBus
{
    public static int Number(List<int[]> peopleListInOut)
    {
        return peopleListInOut.Sum(x => x[0] - x[1]);
    }
}