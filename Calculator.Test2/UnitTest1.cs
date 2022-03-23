using System;
using Xunit;

namespace Calculator.Test2
{
    public class UnitTest1
    {
        [Fact]
        public void Add_SimpleValueShouldCalculate()
        {
            XUnit_Calculator.Calculator calculator = new XUnit_Calculator.Calculator();

            // Arrange
            double expectedResult = 5;

            // Act
            double actualResult = calculator.Add(3, 2);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
