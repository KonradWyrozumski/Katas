using NUnit.Framework;
namespace Katas.Codility.CSharp.FrogRiverOne
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        [TestCase(5, new[] { 1, 3, 1, 4, 2, 3, 5, 4 }, 6)]
        [TestCase(5, new[] { 5, 1, 2, 3, 4 }, 4)]
        [TestCase(6, new[] { 1, 2, 3, 4 }, -1)]
        public void Solution_ForInput_ShouldReturnCorrectResult(int position, int[] inputArray, int result)
        {
            // Arrange
            var kata = new Kata();

            // Act
            var solutionResult = kata.solution(position, inputArray);

            // Assert
            Assert.AreEqual(result, solutionResult);
        }
    }
}