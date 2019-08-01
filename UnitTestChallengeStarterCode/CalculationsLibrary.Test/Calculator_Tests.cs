using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CalculationsLibrary.Test
{
    public class Calculator_Tests
    {
        [Theory]
        [InlineData(5, 4, 9)]
        [InlineData(8, 3, 11)]
        [InlineData(1.25, 3.4, 4.65)]
        public void Add_StandardTest(double x, double y, double expected)
        {
            double actual = Calculator.Add(x, y);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 4, 1, 10, 9)]
        [InlineData(8, 3, 1, 10, 11)]
        [InlineData(1.25, 3.4, 1, 10, 4.65)]
        public void LimitedAdd_StandardTest(double x, double y, double min, double max, double expected)
        {
            double actual = Calculator.LimitedAdd(x, y, min, max);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-2, 6, 1, 10, "x")]
        [InlineData(5, 15, 1, 10, "y")]
        public void LimitedAdd_OutOfRangeParameters_ShouldThrowException(
            double x, double y, double min, double max, string badVariable)
        {
            Assert.Throws<ArgumentOutOfRangeException>(badVariable, () => Calculator.LimitedAdd(x, y, min, max));
        }

        [Theory]
        [InlineData(3, 6, .5)]
        [InlineData(3, 1, 3)]
        public void Divide_StandardTest(double x, double y, double expeced)
        {
            double actual = Calculator.Divide(x, y);

            Assert.Equal(expeced, actual);
        }

        [Fact]
        public void Divide_InvalidData_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => Calculator.Divide(6, 0));
        }

    }
}
