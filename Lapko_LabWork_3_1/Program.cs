using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lapko_LabWork_3_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            const int MyMax = 200;

            Random random = new Random();
            // random.Next(MaxValue) returns a 32-bit signed integer that is greater than or equal to 0 and less than MaxValue
            int Guess_number = random.Next(MyMax) + 1;
            // implement input of number and comparison result message in the while circle with  comparison condition

            int number;

            do
            {
                Console.Write("Enter your guess: ");
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number == Guess_number)
                    {
                        Console.WriteLine("{0} - is right! Congratulations.", number);
                    }
                    else if (number > Guess_number)
                    {
                        Console.WriteLine("Too high!");
                    }
                    else
                    {
                        Console.WriteLine("Too low!");
                    }
                }
                else
                { 
                    Console.WriteLine("Number must be int! Re-enter.");
                }
            }
            while (number != Guess_number);

            Console.WriteLine("Press any key...");
            Console.ReadLine();
        }
    }
}
