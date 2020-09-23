using System;
using Xunit;

namespace ConsoleCalc.Tests
{
    public class ConsoleCalcTests
    {
        [Fact]
        public void AdditionNormalTest()
        {
            //Arrange
            double number1 = 1;
            double number2 = 2;
            double expected = 3;

            //Act
            double actual = ConsoleCalc.Program.Addition(number1, number2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DivisionNormalTest()
        {
            //Arrange
            double number1 = 1;
            double number2 = 3;
            double expected = 0.333;

            //Act
            double actual = ConsoleCalc.Program.Divison(number1, number2);

            //Assert
            Assert.Equal(expected, actual, 3);
        }
    }
}
