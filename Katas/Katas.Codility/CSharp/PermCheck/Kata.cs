using System.Collections.Generic;
using System.Linq;

namespace Katas.Codility.CSharp.PermCheck
{
    public class Kata
    {
        public int solution(int[] A)
        {
            var hashSet = new HashSet<int>();

            var count = A.Count();
            for (int i = 0; i < count; i++)
            {
                hashSet.Add(A[i]);
            }

            return hashSet.Count == count && A.Max() == count? 1 : 0;
        }
    }
}