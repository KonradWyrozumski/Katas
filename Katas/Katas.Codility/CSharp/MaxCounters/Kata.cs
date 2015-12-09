using System.Linq;

namespace Katas.Codility.CSharp.MaxCounters
{
    public class Kata
    {
        public int[] solution(int N, int[] A)
        {
            var counters = new int[N];
            int maxCounter = 0;
            var setAll = 0;

            for (int i = 0; i < A.Count(); i++)
            {
                if (A[i] <= N)
                {
                    var newCounter = Increase(A[i], counters);
                    maxCounter = maxCounter < newCounter ? newCounter : maxCounter;
                }
                else if (A[i] == N + 1)
                {
                    setAll = maxCounter;
                }
            }

            return counters.Select(x => x + setAll).ToArray();
        }

        private int Increase(int X, int[] counters)
        {
            return ++counters[X - 1];
        }
    }
}