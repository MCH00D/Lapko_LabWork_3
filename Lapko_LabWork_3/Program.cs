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
                    FarmePuzzle();
                    Console.WriteLine("");
                    break;
                case 2:
                    Calculator();
                    Console.WriteLine("");
                    break;
                case 3:
                    FactorialCalculation();
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
        static void FarmePuzzle()
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

            int[] userOption = new int[7];

            for (int i = 0; i < 7; i++)
            {

                Console.Write("Step {0}: ", i + 1);

                int option;
                if (!int.TryParse(Console.ReadLine(), out option) && option > 0 && option <= 8)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The entered value must be a number from 1 to 8!");
                    Console.ForegroundColor = ConsoleColor.White;

                    return;
                }

                userOption[i] = option;
                if (string.Concat(userOption).Substring(0, i + 1) != "3817283".Substring(0, i + 1)
                    && string.Concat(userOption).Substring(0, i + 1) != "3827183".Substring(0, i + 1))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Oops. You lose :(");
                    Console.Beep(150, 200);
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }

            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Congratulations, you win! :)");
            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion

        #region Calculator
        public static void Calculator()
        {
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

        public static double? GetDoubleValueFromConsole()
        {
            double number;

            if (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Number must be double!");
                Console.ForegroundColor = ConsoleColor.White;

                return null;
            }

            return number;
        }

        public static void Multiplication()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Multiplication");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Enter the number 1: ");
            var number1 = GetDoubleValueFromConsole();

            if (number1 == null)
            {
                return;
            }

            Console.Write("Enter the number 2: ");
            var number2 = GetDoubleValueFromConsole();

            if (number2 == null)
            {
                return;
            }

            Console.WriteLine("Result: {0}", number1 * number2);

        }

        public static void Divide()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Divide");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Enter the number 1: ");
            var number1 = GetDoubleValueFromConsole();

            if (number1 == null)
            {
                return;
            }

            Console.Write("Enter the number 2: ");
            var number2 = GetDoubleValueFromConsole();

            if (number2 == null)
            {
                return;
            }

            Console.WriteLine("Result: {0}", number1 / number2);
        }

        public static void Addition()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Addition");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Enter the number 1: ");
            var number1 = GetDoubleValueFromConsole();

            if (number1 == null)
            {
                return;
            }

            Console.Write("Enter the number 2: ");
            var number2 = GetDoubleValueFromConsole();

            if (number2 == null)
            {
                return;
            }

            Console.WriteLine("Result: {0}", number1 + number2);
        }

        public static void Subtraction()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Subtraction");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Enter the number 1: ");
            var number1 = GetDoubleValueFromConsole();

            if (number1 == null)
            {
                return;
            }

            Console.Write("Enter the number 2: ");
            var number2 = GetDoubleValueFromConsole();

            if (number2 == null)
            {
                return;
            }

            Console.WriteLine("Result: {0}", number1 - number2);
        }

        public static void Exponentiation()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Exponentiation");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Enter the number 1: ");
            var number1 = GetDoubleValueFromConsole();

            if (number1 == null)
            {
                return;
            }

            Console.Write("Enter the number 2: ");
            var number2 = GetDoubleValueFromConsole();

            if (number2 == null)
            {
                return;
            }

            Console.WriteLine("Result: {0}", Math.Pow((double)number1, (double)number2));
        }

        #endregion

        #region Factorial
        public static void FactorialCalculation()
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
                Console.WriteLine("Number must be ulong!");
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
