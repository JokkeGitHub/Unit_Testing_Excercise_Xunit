using System;
using Xunit;

namespace Calculator.Test2
{
    public class UnitTest1
    {
        [Fact]
        public void Add_Fact_SimpleValueShouldCalculate()
        {
            XUnit_Calculator.Calculator calculator = new XUnit_Calculator.Calculator();

            // Arrange
            double expectedResult = 5;

            // Act
            double actualResult = calculator.Add(3, 2);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(4, 3, 7)]
        [InlineData(21, 5.25, 26.25)]
        [InlineData(double.MaxValue, 5, double.MaxValue)]
        public void Add_Theory_SimpleValueShouldCalculate(double no1, double no2, double expectedResult)
        {
            XUnit_Calculator.Calculator calculator = new XUnit_Calculator.Calculator();

            // Arrange

            // Act
            double actualResult = calculator.Add(no1, no2);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(8, 4, 2)]
        public void Divide_Theory_SimpleValueShouldCalculate(double no1, double no2, double expectedResult)
        {
            XUnit_Calculator.Calculator calculator = new XUnit_Calculator.Calculator();

            // Arrange

            // Act
            double actualResult = calculator.Divide(no1, no2);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void Divide_Fact_DivideByZero()
        {
            XUnit_Calculator.Calculator calculator = new XUnit_Calculator.Calculator();

            // Arrange
            double expectedResult = 0;

            // Act
            double actualResult = calculator.Divide(15, 0);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
