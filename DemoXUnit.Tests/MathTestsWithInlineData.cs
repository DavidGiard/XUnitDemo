using Xunit;

namespace DemoXUnit.Tests
{
    public class MathTestsWithInlineData
    {
        private readonly MathFunctions _math;
        public MathTestsWithInlineData()
        {
            this._math = new MathFunctions();
        }

        [Theory]
        [InlineData(1, 3, 4)]
        [InlineData(-1, -3, -4)]
        [InlineData(-1, 3, 2)]
        public void AddNumbers_ShouldReturnSum(int firstNumber, int secondNumber, int expectedResult)
        {
            // Arrange

            // Act
            int sum = _math.Add(firstNumber, secondNumber);

            // Assert
            Assert.Equal(expectedResult, sum);
        }
    }
}
