using System.Threading;
using NUnit.Framework;

namespace Katas.Codility.CSharp.PermCheck
{
    [TestFixture]
    public class KataTests
    {
        [TestCase(new[] { 4, 1, 3, 2 }, 1)]
        [TestCase(new[] { 4, 1, 3 }, 0)]
        public void Solution_ForInputCollection_ShouldCheckPermutation(int[] A, int expectedResult)
        {
            // Arrange
            var kata = new Kata();

            // Act
            var result = kata.solution(A);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}