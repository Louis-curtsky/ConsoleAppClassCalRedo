using System;
using System.Collections.Generic;

namespace ConsoleAppClassCalRedo
{
    public class Calculator
    {
//        public int NumberFrom;
//        public int NumberTo;

 //       private double douNum;
//        private double douNumBy;

        public decimal DouNumBy;
        public decimal DouNum;

        public Calculator()
        { 
        }

        public Calculator(decimal douNum, decimal douNumBy)
        {
            this.DouNum = Math.Round(douNum,2);
            this.DouNumBy = Math.Round(douNumBy,2);
        }
        public decimal Addition(decimal douNum, decimal douNumBy)
        {
            this.DouNum = Math.Round(douNum, 2);
            this.DouNumBy = Math.Round(douNumBy, 2); 
            return (this.DouNum + this.DouNumBy);
        }

        public decimal Addition(params decimal[] numbers)
        {
            decimal sums = 0;
            foreach (var number in numbers)
            {
                sums += Math.Round(number,2);
            }
            return Math.Round(sums,2);
        }

        public decimal Subtraction(params decimal[] numbers)
        {
            decimal sums = -0m;
            foreach (var number in numbers)
            {
                sums -= Math.Round(number, 2);
            }
            return Math.Round(sums, 2);
        }
/*
        public decimal Substraction(decimal douNum, decimal douNumBy)
        {
            this.DouNum = Math.Round(douNum, 2);
            this.DouNumBy = Math.Round(douNumBy, 2);
            return (this.DouNum - this.DouNumBy);
        }
*/
        public decimal Multiplication(decimal douNum, decimal douNumBy)
        {
            DouNum = Math.Round(douNum,2);
            DouNumBy = Math.Round(douNumBy,2);
            decimal answer = DouNum * DouNumBy;
            return Math.Round(answer,2);
        }

        public decimal Division(decimal divideNum, decimal divideBy)
        {
            decimal answer = 0;
            if (divideBy == 0)
            {
                throw new DivideByZeroException("You are trying to divide by Zero which is not allow!!!");
            }
            DouNum = Math.Round(divideNum,2);
            DouNumBy  = Math.Round(divideBy,2);
            //            double Answer = (Math.Round(divideNum,2) / Math.Round(divideBy,2));
            answer = DouNum / DouNumBy;
            return Math.Round(answer,2);
        }

    }// End Cal Con 1


}
