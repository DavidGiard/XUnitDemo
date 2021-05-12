using Xunit;

namespace DemoXUnit.Tests
{
    public class MathTests
    {
        private readonly MathFunctions _math;
        public MathTests()
        {
            this._math = new MathFunctions();
        }

        [Fact]
        public void AddPositiveNumbers_ShouldReturnSum()
        {
            // Arrange
            int firstNumber = 1;
            int secondNumber = 3;

            // Act
            int sum = _math.Add(firstNumber, secondNumber);

            // Assert
            Assert.Equal(4, sum);
        }

        [Fact]
        public void AddNegativeNumbers_ShouldReturnSum()
        {
            // Arrange
            int firstNumber = -1;
            int secondNumber = -3;

            // Act
            int sum = _math.Add(firstNumber, secondNumber);

            // Assert
            Assert.Equal(-4, sum);
        }

        [Fact]
        public void AddPositiveAndNegativeNumbers_ShouldReturnSum()
        {
            // Arrange
            int firstNumber = -1;
            int secondNumber = 3;

            // Act
            int sum = _math.Add(firstNumber, secondNumber);

            // Assert
            Assert.Equal(2, sum);
        }
    }
}
