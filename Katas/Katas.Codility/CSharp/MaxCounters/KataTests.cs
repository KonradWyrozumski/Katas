using NUnit.Framework;

namespace Katas.Codility.CSharp.MaxCounters
{
    [TestFixture]
    public class KataTests
    {
        [TestCase(new[] { 3, 4, 4, 6, 1, 4, 4 }, 5, new[] { 3, 2, 2, 4, 2 })]
        [TestCase(new[] { 3, 6, 4, 6, 1, 6, 4 }, 5, new[] { 3, 3, 3, 4, 3, })]
        public void Test(int[] A, int N, int[] expectedResult)
        {
            // Arrange
            var kata = new Kata();

            // Act
            var result = kata.solution(N, A);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}