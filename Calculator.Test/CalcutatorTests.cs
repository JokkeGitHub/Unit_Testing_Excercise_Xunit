using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XUnit_Calculator;
using Xunit;

namespace Calculator.Test
{
    public class CalcutatorTests
    {
        [Fact]
        public void Add_SimpleValueShouldCalculate()
        {
            XUnit_Calculator.Calculator calculator = new XUnit_Calculator.Calculator();

            // Arrange
            double expectedResult = 5;

            // Act
            double actualResult = calculator.Add(8, 2);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
