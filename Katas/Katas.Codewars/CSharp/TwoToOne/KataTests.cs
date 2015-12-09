using System;
using Katas.Codewars.CSharp.TwoToOne;
using NUnit.Framework;

[TestFixture]
public static class TwoToOneTests
{
    [Test]
    public static void test1()
    {
        Assert.AreEqual("aehrsty", TwoToOne.Longest("aretheyhere", "yestheyarehere"));
        Assert.AreEqual("abcdefghilnoprstu", TwoToOne.Longest("loopingisfunbutdangerous", "lessdangerousthancoding"));
        Assert.AreEqual("acefghilmnoprstuy", TwoToOne.Longest("inmanylanguages", "theresapairoffunctions"));
    }
}