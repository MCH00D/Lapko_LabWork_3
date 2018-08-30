using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lapko_LabWork_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            long a;
            Console.WriteLine(@"Please,  type the number:
1. Farmer, wolf, goat and cabbage puzzle
2. Console calculator
3. Factirial calculation
            ");

            a = long.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Farmer_puzzle();
                    Console.WriteLine("");
                    break;
                case 2:
                    Calculator();
                    Console.WriteLine("");
                    break;
                case 3:
                    Factorial_calculation();
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }

        #region Farmer
        static void Farmer_puzzle()
        {
            //Key sequence: 3817283 or 3827183
            // Declare 7 int variables for the input numbers and other variables
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"From one bank to another should carry a wolf, goat and cabbage. 
At the same time can neither carry nor leave together on the banks of a wolf and a goat, 
a goat and cabbage. You can only carry a wolf with cabbage or as each passenger separately. 
You can do whatever how many flights. How to transport the wolf, goat and cabbage that all went well?");
            Console.WriteLine("There: farmer and wolf - 1");
            Console.WriteLine("There: farmer and cabbage - 2");
            Console.WriteLine("There: farmer and goat - 3");
            Console.WriteLine("There: farmer - 4");
            Console.WriteLine("Back: farmer and wolf - 5");
            Console.WriteLine("Back: farmer and cabbage - 6");
            Console.WriteLine("Back: farmer and goat - 7");
            Console.WriteLine("Back: farmer - 8");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please, type numbers by step");
            // Implement input and checking of the 7 numbers in the nested if-else blocks with the  Console.ForegroundColor changing

            Console.ForegroundColor = ConsoleColor.White;

            int step1;
            int step2;
            int step3;
            int step4;
            int step5;
            int step6;
            int step7;

            Console.Write("Step 1: ");

            if (!int.TryParse(Console.ReadLine(), out step1) && step1 > 0 && step1 <= 8)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The entered value must be a number from 1 to 8!");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            else if (step1 != 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Oops. You lose :(");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            Console.Write("Step 2: ");

            if (!int.TryParse(Console.ReadLine(), out step2) && step2 > 0 && step2 <= 8)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The entered value must be a number from 1 to 8!");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            else if (step2 != 8)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Oops. You lose :(");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            Console.Write("Step 3: ");

            if (!int.TryParse(Console.ReadLine(), out step3) && step3 > 0 && step3 <= 8)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The entered value must be a number from 1 to 8!");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            else if (step3 != 1 && step3 != 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Oops. You lose :(");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            else if (step3 == 1)
            {

                Console.Write("Step 4: ");

                if (!int.TryParse(Console.ReadLine(), out step4) && step4 > 0 && step4 <= 8)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The entered value must be a number from 1 to 8!");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
                else if (step4 != 7)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Oops. You lose :(");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }

                Console.Write("Step 5: ");

                if (!int.TryParse(Console.ReadLine(), out step5) && step5 > 0 && step5 <= 8)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The entered value must be a number from 1 to 8!");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
                else if (step5 != 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Oops. You lose :(");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
            }
            else if (step3 == 2)
            {
                Console.Write("Step 4: ");

                if (!int.TryParse(Console.ReadLine(), out step4) && step4 > 0 && step4 <= 8)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The entered value must be a number from 1 to 8!");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
                else if (step4 != 7)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Oops. You lose :(");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }

                Console.Write("Step 5: ");

                if (!int.TryParse(Console.ReadLine(), out step5) && step5 > 0 && step5 <= 8)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The entered value must be a number from 1 to 8!");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
                else if (step5 != 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Oops. You lose :(");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }

            }

            Console.Write("Step 6: ");

            if (!int.TryParse(Console.ReadLine(), out step6) && step6 > 0 && step6 <= 8)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The entered value must be a number from 1 to 8!");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            else if (step6 != 8)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Oops. You lose :(");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            Console.Write("Step 7: ");

            if (!int.TryParse(Console.ReadLine(), out step7) && step7 > 0 && step7 <= 8)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The entered value must be a number from 1 to 8!");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            else if (step7 != 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Oops. You lose :(");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Congratulations, you win! :)");
            Console.ForegroundColor = ConsoleColor.White;

        }
        #endregion

        #region Calculator
        static void Calculator()
        {

            // Set Console.ForegroundColor  value
            Console.Clear();
            Console.WriteLine(@"Select the arithmetic operation:
1. Multiplication 
2. Divide 
3. Addition 
4. Subtraction
5. Exponentiation");

            // Implement option input (1,2,3,4,5)
            //     and input of two or one numbers
            //  Perform calculations and output the result 

            int operation = int.Parse(Console.ReadLine());
            switch (operation)
            {
                case 1:
                    Multiplication();
                    break;
                case 2:
                    Divide();
                    break;
                case 3:
                    Addition();
                    break;
                case 4:
                    Subtraction();
                    break;
                case 5:
                    Exponentiation();
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }
        }

        static void Multiplication()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Multiplication");
            Console.ForegroundColor = ConsoleColor.White;

            double number1;
            double number2;

            Console.Write("Enter the number 1: ");
            if (!double.TryParse(Console.ReadLine(), out number1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Number must be double!");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            Console.Write("Enter the number 2: ");
            if (!double.TryParse(Console.ReadLine(), out number2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Number must be double!");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            Console.WriteLine("Result: {0}", number1 * number2);

        }

        static void Divide()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Divide");
            Console.ForegroundColor = ConsoleColor.White;

            double number1;
            double number2;

            Console.Write("Enter the number 1: ");
            if (!double.TryParse(Console.ReadLine(), out number1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Number must be double!");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            Console.Write("Enter the number 2: ");
            if (!double.TryParse(Console.ReadLine(), out number2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Number must be double!");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            Console.WriteLine("Result: {0}", number1 / number2);
        }

        static void Addition()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Addition");
            Console.ForegroundColor = ConsoleColor.White;

            double number1;
            double number2;

            Console.Write("Enter the number 1: ");
            if (!double.TryParse(Console.ReadLine(), out number1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Number must be double!");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            Console.Write("Enter the number 2: ");
            if (!double.TryParse(Console.ReadLine(), out number2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Number must be double!");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            Console.WriteLine("Result: {0}", number1 + number2);
        }

        static void Subtraction()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Subtraction");
            Console.ForegroundColor = ConsoleColor.White;

            double number1;
            double number2;

            Console.Write("Enter the number 1: ");
            if (!double.TryParse(Console.ReadLine(), out number1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Number must be double!");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            Console.Write("Enter the number 2: ");
            if (!double.TryParse(Console.ReadLine(), out number2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Number must be double!");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            Console.WriteLine("Result: {0}", number1 - number2);
        }

        static void Exponentiation()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Exponentiation");
            Console.ForegroundColor = ConsoleColor.White;

            double number1;
            double number2;

            Console.Write("Enter the number 1: ");
            if (!double.TryParse(Console.ReadLine(), out number1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Number must be double!");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            Console.Write("Enter the number 2: ");
            if (!double.TryParse(Console.ReadLine(), out number2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Number must be double!");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            Console.WriteLine("Result: {0}", Math.Pow(number1, number2));
        }

        #endregion

        #region Factorial
        static void Factorial_calculation()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Factorial");
            Console.ForegroundColor = ConsoleColor.White;

            ulong number;

            // Implement input of the number
            Console.Write("Enter the number: ");
            if (!ulong.TryParse(Console.ReadLine(), out number))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Number must be int!");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            // Implement input the for circle to calculate factorial of the number
            ulong result = 1;
            for (ulong i = number; i > 0; i--)
            {
                result *= i;
            }

            // Output the result
            Console.WriteLine("Result: {0}", result);

        }

        #endregion
    }
}
