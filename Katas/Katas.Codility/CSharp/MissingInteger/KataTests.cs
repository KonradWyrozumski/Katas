using System.Threading;
using NUnit.Framework;

namespace Katas.Codility.CSharp.MissingInteger
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        [TestCase(new[] { 1, 3, 6, 4, 1, 2 }, 5)]
        [TestCase(new[] { 2 }, 1)]
        [TestCase(new[] { 1 }, 2)]
        [TestCase(new[] { -1, -2, 0, 1, 3 }, 2)]
        public void Solution_ForInput_ShouldReturnCorrectResult(int[] inputArray, int result)
        {
            // Arrange
            var kata = new Kata();

            // Act
            var solutionResult = kata.Solution(inputArray);

            // Assert
            Assert.AreEqual(result, solutionResult);
        }
    }
}