using System;

namespace mssa_5._4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input any number : ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                Console.Write($"The digits in the number {number} are : ");
                DisplayDigits(number);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        static void DisplayDigits(int n)
        {
            if (n < 0)
            {
                Console.Write("- ");
                n = -n;
            }
            if (n < 10)
            {
                Console.Write($"{n} ");
            }
            else
            {
                DisplayDigits(n / 10);
                Console.Write($"{n % 10} ");
            }
        }
    }
}
