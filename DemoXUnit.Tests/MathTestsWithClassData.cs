using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DemoXUnit.Tests
{
    public class MathTestsWithClassData
    {
        private readonly MathFunctions _math;
        public MathTestsWithClassData()
        {
            this._math = new MathFunctions();
        }

        [Theory]
        [ClassData(typeof(MathTestsData))]
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
