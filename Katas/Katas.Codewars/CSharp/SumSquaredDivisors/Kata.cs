using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas.Codewars.CSharp.SumSquaredDivisors
{
    public class SumSquaredDivisors
    {
        public static string listSquared(long m, long n)
        {
            var squared = new List<string>();

            for (long i = m; i <= n; i++)
            {
                var divisors = FindDivisors(i);
                var poweredDivisors = divisors.Select(x => Math.Pow(x, 2));
                var sumOfPoweredDivisors = poweredDivisors.Sum();
                var square = Math.Sqrt(sumOfPoweredDivisors);
                if (square % 1 == 0)
                {
                    squared.Add(string.Format("[{0}, {1}]", i, sumOfPoweredDivisors));
                }
            }

            return "[" + string.Join(", ", squared) + "]";
        }

        private static List<long> FindDivisors(long number)
        {
            var divisors = new List<long>();

            int squareRoot = (int)Math.Ceiling(Math.Sqrt(number));

            if (number == 1)
            {
                divisors.Add(number);
            }

            for (long i = 1; i < squareRoot; i++)
            {
                if (number % i == 0)
                {
                    divisors.Add(i);
                    divisors.Add(number / i);
                }
            }

            return divisors;
        }
    }
}