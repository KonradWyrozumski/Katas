namespace Katas.Codewars.CSharp.SplitInParts
{
    public class Kata
    {
        public static string SplitInParts(string s, int partLength)
        {
            string splittedString = string.Empty;

            for (int i = 1; i < s.Length; i++)
            {
                splittedString += s[i - 1];

                if (i % partLength == 0)
                {
                    splittedString += " ";
                }
            }

            splittedString += s[s.Length - 1];

            return splittedString;
        }
    }
}