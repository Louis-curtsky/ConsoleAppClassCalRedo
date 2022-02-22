using System;
using System.Collections.Generic;
using ConsoleAppClassCalRedo;

namespace ConsoleAppClassCalRedo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            do
            {
                PrintMenu();

                int assignmentSel = int.Parse(Console.ReadLine() ?? "0");

                if (assignmentSel < 6 && assignmentSel > 0)
                {
                    MathOperation(assignmentSel);
                }
                else if (assignmentSel == 9)
                {
                    keepGoing = false;
                    Console.WriteLine("Good bye!!!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid selection !!!");
                }
                Console.ResetColor();
                Console.WriteLine("Press any key to continue !");
                // key press hidden with (True)
                Console.ReadKey();
                Console.Clear();
            } while (keepGoing);
        }// End of Main

        static void MathOperation(int selection)
        {
            var sum = new Calculator();
            int tot = 0;
            bool listInputEnd = false;
                     double InputD1 = 0;
                     double InputD2 = 0;

            List<int> numberList = new List<int>();   
            switch (selection)
            {
                case 1:
                    int firstnum = UserInputNumber("Enter 1st number");
                    int secondnum = UserInputNumber("Enter 2nd number");
                    Console.WriteLine(firstnum + " + " + secondnum + " is = "+sum.Addition(firstnum, secondnum));
                    break;
                case 2:
                    while (listInputEnd == false)
                    {
                        int addToListm = UserInputNumber("Add number to list (0 to end): ");
                        if (addToListm == 0)
                        {
                            listInputEnd = true;
                        }
                        else
                        {
                            numberList.Add(addToListm);
                        }
                    }
                            for (int i = 0; i < numberList.Count; i++)
                            {
                                tot += sum.Addition(numberList[i]);
                            }
                    Console.WriteLine(tot);
  //                  Console.WriteLine("Sum List is = "+sum);
                    break;
                case 3:
                    Console.WriteLine(" is = ");
                    break;
                case 4:
                     Console.WriteLine(" is = ");
                    break;
                case 5:
                    InputD1 = 45.67777;
                    InputD2 = 3.67778;
                    var sumDou = new Calculator(InputD1,InputD2);

                    Console.WriteLine($"{InputD1} / {InputD2} equal to {sumDou.Division(InputD1,InputD2)}");
                    break;
            }
        }
        static int UserInputNumber(string desc)
        {
            string inputed = UserInputStr(desc);
            int number = Convert.ToInt32(inputed);
            return number;
        }
        
        static double UserInputDouble(string desc)
        {
            string inputed = UserInputStr(desc);
            double number = Convert.ToDouble(inputed);
            return number;
        }

        static string UserInputStr(string userinputstr)
        {
            Console.Write("Please enter " + userinputstr + ": ");
            return Console.ReadLine();
        }

        static void PrintMenu()
        {
            Console.WriteLine("----- Menu -----");
            Console.WriteLine("1: ADD Two numbers");
            Console.WriteLine("2: ADD more than TWO numbers");
            Console.WriteLine("3: MULTIPLICATION Operation");
            Console.WriteLine("5: DIVISION Operation");
            Console.WriteLine("9: Exit program");
            Console.WriteLine("\nEnter you choice: ");
        }

    }
}
