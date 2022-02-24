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
                try
                {
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
                }
                catch (ArgumentNullException)//will probebly never happen in this method
                {
                    Console.WriteLine("No selection was entered.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a proper number!!!");
                }
                catch (DivideByZeroException exception)
                {
                    Console.WriteLine(exception.Message);
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("You had enter a Zero !!!");
                }
            } while (keepGoing);
        }// End of Main

        static void MathOperation(int selection)
        {
            var sum = new Calculator();
            decimal tot = 0;
            bool listInputEnd = false;
            decimal InputD1 = 0;
            decimal InputD2 = 0;
            List<decimal> numberList = new List<decimal>();

                switch (selection)
                {
                    case 1:
                        InputD1 = UserInputDouble("Enter 1st number");
                        InputD2 = UserInputDouble("Enter 2nd number");
                        tot = sum.Addition(InputD1, InputD2);
                        Console.WriteLine(InputD1 + " + " + InputD2 + " is = " + tot.ToString("+#.##;-#.##;0"));
                        //                  Console.WriteLine(tot);
                        break;
                    case 2:
                        while (listInputEnd == false)
                        {
                            decimal addToList = UserInputDouble("Add number to list (0 to end): ");
                            if (addToList == 0)
                            {
                                listInputEnd = true;
                            }
                            else
                            {
                                numberList.Add(addToList);
                            }
                        }
                        for (int i = 0; i < numberList.Count; i++)
                        {
                            //                              Console OUT member from LIST
                            //                              Console.WriteLine($"Number List {i} is {numberList[i]}");
                            tot = tot + Math.Round(sum.Addition(numberList[i]), 2);
                        }
                        Console.WriteLine(tot.ToString("+#.##;-#.##;0"));
                        break;
                    case 3:
                        while (listInputEnd == false)
                        {
                            decimal addToList = UserInputDouble("Add number to list (0 to end): ");
                            if (addToList == 0)
                            {
                                listInputEnd = true;
                            }
                            else
                            {
                                numberList.Add(addToList);
                            }
                        }
                        for (int i = 0; i < numberList.Count; i++)
                        {
                            Console.WriteLine($"Number List {i} is {numberList[i]}");
                            tot = tot + Math.Round(sum.Subtraction(numberList[i]), 2);
                        }
                        Console.WriteLine("Subtraction balance = " + tot.ToString("+#.##;-#.##;0"));
                        break;
                    case 4:
                        InputD1 = UserInputDouble("Enter 1st number");
                        InputD2 = UserInputDouble("Enter 2nd number");
                        tot = sum.Multiplication(InputD1, InputD2);
                        Console.WriteLine(InputD1 + " + " + InputD2 + " is = " + tot.ToString("+#.##;-#.##;0"));
                        break;
                    case 5:
                        InputD1 = UserInputDouble("Enter 1st number");
                        InputD2 = UserInputDouble("Enter 2nd number");
                        var sumDou = new Calculator(InputD1, InputD2);
                        Console.WriteLine($"{InputD1} / {InputD2} equal to {sumDou.Division(InputD1,InputD2)}");
                        break;
                } // End of Switch
        }// End MathOperation
   
        static decimal UserInputDouble(string desc)
        {
                string inputed = UserInputStr(desc);
                decimal number = Convert.ToDecimal(inputed);
                return number;
        }// End UserInputDouble

        static string UserInputStr(string userinputstr)
        {
            Console.Write("Please enter " + userinputstr + ": ");
            return Console.ReadLine();
        }//End UserInoutStr

        static void PrintMenu()
        {
            Console.WriteLine("----- Menu -----");
            Console.WriteLine("1: ADD Two numbers");
            Console.WriteLine("2: ADD more than TWO numbers");
            Console.WriteLine("3: MINUS Operation");
            Console.WriteLine("4: MULTIPLICATION Operation");
            Console.WriteLine("5: DIVISION Operation");
            Console.WriteLine("9: Exit program");
            Console.WriteLine("\nEnter you choice: ");
        }// End PrintMenu

    }
}
