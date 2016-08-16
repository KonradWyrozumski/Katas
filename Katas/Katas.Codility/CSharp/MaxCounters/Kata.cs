using System;

namespace Katas.Codility.CSharp.MaxCounters
{
    public class Kata
    {
        public int[] solution(int N, int[] A)
        {
            int[] result = new int[N];
            int maximum = 0;

            for (int K = 0; K < A.Length; K++)
            {
                if (A[K] < 1 || A[K] > N + 1)
                    throw new InvalidOperationException();

                if (A[K] >= 1 && A[K] <= N)
                {
                    result[A[K] - 1]++;

                    if (result[A[K] - 1] > maximum)
                    {
                        maximum = result[A[K] - 1];
                    }
                }
                else
                {
                    // inefficiency here
                    for (int i = 0; i < result.Length; i++)
                        result[i] = maximum;
                }
            }

            return result;
        }
    }
}