using System;
using System.Linq;

namespace Katas.Codility.CSharp.FrogRiverOne
{
    public class Kata
    {
        public int solution(int X, int[] A)
        {
            bool[] stepPassed = new bool[X + 1];
            for (int i = 0; i < A.Count(); i++)
            {
                if (!stepPassed[A[i]])
                {
                    stepPassed[A[i]] = true;
                    X--;
                }
                if (X == 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}