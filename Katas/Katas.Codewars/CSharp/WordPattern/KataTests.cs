using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Katas.Codewars.CSharp.WordPattern
{
    [TestFixture]
    public class WordPatternTest
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(true, Kata.WordPattern("abab", "apple banana apple banana"));
            Assert.AreEqual(true, Kata.WordPattern("abba", "car truck truck car"));
            Assert.AreEqual(false, Kata.WordPattern("abab", "apple banana banana apple"));
            Assert.AreEqual(true, Kata.WordPattern("aaaa", "cat cat cat cat"));
            Assert.AreEqual(false, Kata.WordPattern("aaaa", "cat cat dog cat"));
            Assert.AreEqual(true, Kata.WordPattern("bbbabcb", "c# c# c# javascript c# python c#"));
            Assert.AreEqual(true, Kata.WordPattern("abcdef", "apple banana cat donkey elephant flower"));
            Assert.AreEqual(false, Kata.WordPattern("xyzzyx", "apple banana apple banana"));
            Assert.AreEqual(true, Kata.WordPattern("xyzzyx", "1 2 3 3 2 1"));
            Assert.AreEqual(true, Kata.WordPattern("aafggiilp", "cow cow fly pig pig sheep sheep chicken aardvark"));
            Assert.AreEqual(false, Kata.WordPattern("aafggiilp", "cow cow fly rooster pig sheep sheep chicken aardvark"));
            Assert.AreEqual(false, Kata.WordPattern("aaaa", "cat cat cat"));
            Assert.AreEqual(false, Kata.WordPattern("abba", "dog dog dog dog"));
        }
    }
}