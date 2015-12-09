using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas.Codewars.CSharp.WordPattern
{
    public class Kata
    {
        public static bool WordPattern(string pattern, string str)
        {
            str = TransformWordsIntoCommonPattern(str);

            pattern = TransformPatternIntoCommonPattern(pattern);

            return pattern == str;
        }

        private static string TransformPatternIntoCommonPattern(string pattern)
        {
            var uniqueCharacters = new HashSet<char>();
            foreach (var character in pattern)
            {
                uniqueCharacters.Add(character);
            }
            var charactersWithSequence = new Dictionary<char, int>();

            foreach (var uniqueCharacter in uniqueCharacters.Select((value, i) => new {i, value}))
            {
                charactersWithSequence.Add(uniqueCharacter.value, uniqueCharacter.i);
            }

            foreach (var characterWithSequence in charactersWithSequence)
            {
                pattern = pattern.Replace(characterWithSequence.Key.ToString(), characterWithSequence.Value.ToString());
            }
            return pattern;
        }

        private static string TransformWordsIntoCommonPattern(string str)
        {
            var splittedWords = str.Split(' ');

            var uniqueWords = new HashSet<string>();
            foreach (var splittedWord in splittedWords)
            {
                uniqueWords.Add(splittedWord);
            }

            var wordsWithSequence = new Dictionary<string, int>();

            foreach (var uniqueWord in uniqueWords.Select((value, i) => new {i, value}))
            {
                wordsWithSequence.Add(uniqueWord.value, uniqueWord.i);
            }

            foreach (var wordWithSequence in wordsWithSequence)
            {
                str = str.Replace(wordWithSequence.Key, wordWithSequence.Value.ToString());
            }

            str = str.Replace(" ", string.Empty);

            return str;
        }
    }
}