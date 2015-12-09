using System.Collections.Generic;
using System.Linq;

namespace Katas.Codewars.CSharp.TwoToOne
{
    public class TwoToOne
    {
        public static string Longest(string s1, string s2)
        {
            var s1Array = s1.ToCharArray();
            var s2Array = s2.ToCharArray();
            HashSet<char> uniqueCharactesSet = new HashSet<char>();

            foreach (var s1Char in s1Array)
            {
                uniqueCharactesSet.Add(s1Char);
            }
            foreach (var s2Char in s2Array)
            {
                uniqueCharactesSet.Add(s2Char);
            }

            var allUniqueCharactes = uniqueCharactesSet.ToList();
            allUniqueCharactes.Sort();
            return new string(allUniqueCharactes.ToArray());
        }
    }
}