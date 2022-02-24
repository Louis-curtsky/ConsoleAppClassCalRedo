using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ConsoleAppClassCalRedo;

namespace ConsoleAppClassCalRedo.Test
{
    public class CalculatorTest
    {
        //   [Fact]
        //   public void Test1()
        //   {
        //Arrange

        //Act

        //Assert
        //   }

        [Fact]
        public void TwoNumberTest1()
        {
            //Arrange
            decimal doNum = 23.5m;
            decimal doNumBy = 35.3m;
            //Act
            Calculator answer = new Calculator(doNum, doNumBy);
            //Assert
            Assert.NotNull(answer);
            Assert.Equal(doNum, answer.DouNum);
            Assert.Equal(doNumBy, answer.DouNumBy);
        }

        [Fact]
        public void ArrayAddTest()
        {
            //Arrange
            List<decimal> numberList = new List<decimal>() { 1.1m, -3.3m, 5, 7, 8.8m };
            Calculator calculator = new Calculator();
            decimal result = 0m;
            decimal expectedSum = 18.6m;
            //Act
            for (int i = 0; i < numberList.Count; i++)
            {
                result += calculator.Addition(numberList[i]);
            }
            //Assert
            Assert.Equal(expectedSum, result, 2);
        }

        [Fact]
        public void ArraySubtractionTest()
        {
            //Arrange
            List<decimal> numberList = new List<decimal>() { 1.1m, -3.3m, 5, 7, 8.8m };
            Calculator calculator= new Calculator();
            decimal result = -0m;
            decimal expectedSum = -16.4m;
            //Act
                result = result + calculator.Subtraction(numberList);

            //Assert
            Assert.Equal(expectedSum, result, 2);
        }

        public static IEnumerable<object[]> SubtractTest2()
        {
            yield return new object[] {
                new List<decimal>() { 1.1m, -3.3m, 5m, 7m, 8.8m },   //numbers
                -16.4m                                   //expected
            };

            yield return new object[] {
                new List<decimal>() { -2.2m, 5.5m, -8.2m, 61.1m },   //numbers
                -60.6m                                   //expected
            };
        }

        [Theory]
        [MemberData(nameof(SubtractTest2))]
        public void DecimalListManyTest(List<decimal> numbers, decimal expected)
        {
            //Arrange
            //MemberData will provide the date
            Calculator calculator = new Calculator();
            //Act - will just do simple addition math to sum all the values
            decimal result = calculator.Subtraction(numbers);//Linq has this nice sum method

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(30,40,70)]
        [InlineData(25,-54,-29)]
        [InlineData(45.76,-335.37,-289.61)]
        public void AdditionTest(decimal doNum, decimal doNumBy, decimal expectedSum)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            decimal result = calculator.Addition(doNum, doNumBy);

            //Assert
            Assert.Equal(expectedSum, result, 2);
        }

        [Theory]
        [InlineData(30, 40, 1200)]
        [InlineData(25, -54, -1350)]
        [InlineData(45.76, -335.37, -15346.53)]
        public void MultiplicationTest(decimal doNum, decimal doNumBy, decimal expectedSum)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            decimal result = calculator.Multiplication(doNum, doNumBy);

            //Assert
            Assert.Equal(expectedSum, result, 2);
        }

        [Theory]
        [InlineData(1200, 40, 30)]
        [InlineData(-1350, -54, 25)]
        [InlineData(-15346.53, -335.37, 45.76)]
        public void DivisionTest(decimal doNum, decimal doNumBy, decimal expectedSum)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            decimal result = calculator.Division(doNum, doNumBy);

            //Assert
            Assert.Equal(expectedSum, result, 2);
        }


    }
}

