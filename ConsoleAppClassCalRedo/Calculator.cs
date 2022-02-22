using System;
using System.Collections.Generic;

namespace ConsoleAppClassCalRedo
{
    public class Calculator
    {
        public int NumberFrom;
        public int NumberTo;

        private double douNum;
        private double douNumBy;

        public double DouNumBy
        { 
            get { return douNumBy; } 
            set { douNumBy = Math.Round(DouNumBy, 2); }
        }
            
        public double DouNum
        {
            get { return douNum; }
            set { douNum = Math.Round(douNum, 2); }
        }

        public Calculator()
        { 
        }

        public Calculator(int numberFrom, int numberTo)
        {
            NumberFrom = numberFrom;
            NumberTo = numberTo;
        }

        public Calculator(double dounumber, double dounumberBy)
        {
            DouNum = dounumber;
            DouNumBy = dounumberBy;
        }
        public int Addition(int numberFrom, int numberTo)
        {
            this.NumberFrom = numberFrom;
            this.NumberTo = numberTo;
            return (numberFrom+numberTo);
        }

        public int Addition(params int[] numbers)
        {
            var sums = 0;
            foreach (var number in numbers)
            {
                sums += number;
            }
            return sums;
        }

        
        public int Substraction(int subtrent)
        {
            int Answer = (NumberFrom - subtrent);
            return Answer;
        }

        public double multiplication(double douNum, double doubNumBy)
        {
            this.DouNum = douNum;
            this.DouNumBy = douNumBy;
            double Answer = douNum * douNumBy;
            return Answer;
        }


        public double Division(double divideNum, double divideBy)
        {
            if (divideBy == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(divideBy));
            }
            this.DouNum = divideNum;
            this.DouNumBy = divideBy;
            //            double Answer = (Math.Round(divideNum,2) / Math.Round(divideBy,2));
            double Answer = divideNum / divideBy;
            return Math.Round(Answer,2);
        }

    }// End Cal Con 1


}
