using System;

namespace OddOrEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a number (or q to quit): ");
                string input = Console.ReadLine();

                if (input == "q")
                {
                    break; 
                }

                if (int.TryParse(input, out int number))
                {
                    OddOrEven(number);
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
        }

        static void OddOrEven(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even!");
            }
            else
            {
                Console.WriteLine($"{number} is odd!");
            }
        }
    }
}