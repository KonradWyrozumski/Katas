using NUnit.Framework;
using System;
using System.Collections.Generic;

[TestFixture]
public class Tests
{
    [Test]
    [TestCase(54,   new int[] { 54, 27, 18, 9, 6, 3, 2, 1 })]
    [TestCase(9, new int[] { 9, 3, 1 })]
    public static void FixedTest(int num, int[] expectedResult)
    {
        Assert.AreEqual(expectedResult, Kata.Factors(num));
    }
}