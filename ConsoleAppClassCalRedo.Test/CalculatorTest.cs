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
            for (int i = 0; i < numberList.Count; i++)
            {
                result = result + calculator.Subtraction(numberList);
            }
            //Assert
            Assert.Equal(expectedSum, result, 2);
        }

/*
        [Theory]
        [InlineData(new decimal[] { 1.1m, -3.3m, 5, 7, 8.8m }, 18.6m)]
        public void SubtractionTest2(decimal[] numberList, decimal expectedSum)
        {
            //Arrange

            Calculator calculator = new Calculator();
            decimal result = -0m;

            //Act
            for (int i = 0; i < numberList.Count; i++)
            {
                result = result + calculator.Subtraction(numberList[i]);
            }
            //Assert
            Assert.Equal(expectedSum, result, 2);
        }
*/

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

