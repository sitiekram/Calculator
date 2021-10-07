using System;
using Xunit;
using Calculator;
namespace Calculator.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void AdditionTest()
        {
            double expected = 24.4;
            double num1 = 10.1;
            double num2 = 14.3;
            double actual = Program.Addition(num1, num2);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new double[] { 8, 7.5, 6, 3 }, 24.5)]
        [InlineData(new double[] { -32, 4.5, 99 }, 71.5)]
        public void AdditionWithArrayInputTest(double[] input, double expected)
        {
            double actual = Program.Addition(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SubtractionTest()
        {
            double expected = -16;
            double num1 = 10;
            double num2 = 26;
            double actual = Program.Subtraction(num1, num2);

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(new double[] { 100, 10, 4, 6, 25 }, 55)]
        [InlineData(new double[] { 12, 22, 35 }, -45)]
        public void SubtractionWithArrayInputTest(double[] input, double expected)
        {
            double actual = Program.Subtraction(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MultiplicationTest()
        {
            double expected = 125;
            double num1 = 5;
            double num2 = 25;

            double actual = Program.Multiplication(num1, num2);

            Assert.Equal(expected, actual);
        }
        [Fact]
         public void DivisionTest()
        {
            double num1 = 1;
            double num2 = 3;
            double expected = 0.3333;

            double actual = Program.Division(num1,num2);

            Assert.Equal(expected, actual,4);
        }

        [Fact]
        public void DivisionTestByZero()
        {
            double num1 = 11;
            double num2 = 0;

            double actual = Program.Division(num1, num2);
            Assert.True(double.IsInfinity(actual));
        }

    }
}


