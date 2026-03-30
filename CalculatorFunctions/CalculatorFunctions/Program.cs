using System;

namespace CalculatorFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = "";

            while (operation != "+" && operation != "-" && operation != "*" && operation != "/")
            {
                Console.Write("Choose: +, -, *, / ");
                operation = Console.ReadLine();

                if (operation != "+" && operation != "-" && operation != "*" && operation != "/")
                {
                    Console.WriteLine("Invalid operation. Try again.");
                }
            }

            int a;
            Console.Write("Enter first number: ");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Invalid number. Try again.");
                Console.Write("Enter first number: ");
            }

            int b;
            Console.Write("Enter second number: ");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Invalid number. Try again.");
                Console.Write("Enter second number: ");
            }

            if (operation == "+")
            {
                Add(a, b, operation);
            }
            else if (operation == "-")
            {
                Subtract(a, b, operation);
            }
            else if (operation == "*")
            {
                Multiply(a, b, operation);
            }
            else if (operation == "/")
            {
                Divide(a, b, operation);
            }
            else
            {
                Console.WriteLine("Wrong operation");
            }
        }

        public static void Add(int a, int b, string operation)
        {
            Console.WriteLine($"{a} {operation} {b} = {a + b}");
        }

        public static void Subtract(int a, int b, string operation)
        {
            Console.WriteLine($"{a} {operation} {b} = {a - b}");
        }

        public static void Multiply(int a, int b, string operation)
        {
            Console.WriteLine($"{a} {operation} {b} = {a * b}");
        }

        public static void Divide(int a, int b, string operation)
        {
            if (b == 0)
            {
                Console.WriteLine("Cannot divide by 0");
            }
            else
            {
                Console.WriteLine($"{a} {operation} {b} = {a / b}");
            }
        }
    }
}