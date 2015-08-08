using System;
using System.Linq;

namespace Katas.Codility.CSharp.MissingInteger
{
    public class Kata
    {
        public int Solution(int[] inputIntegers)
        {
            Array.Sort(inputIntegers);
            var positiveInputIntegers = inputIntegers.Where(x => x > 0).ToList();

            int min = 1;
            foreach (var positiveInputInteger in positiveInputIntegers)
            {
                if (positiveInputInteger == min)
                {
                    min++;
                }
            }

            return min;
        }
    }
}