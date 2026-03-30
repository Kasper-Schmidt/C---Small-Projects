using System;
using System.IO;

namespace WriteToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\bought.txt");

            Console.WriteLine("Write item and price - (type 'q' to quit):");

            while (true)
            {
                Console.Write("What did you buy? ");
                string item = Console.ReadLine();

                if (item == "q")
                {
                    break;
                }

                if (string.IsNullOrWhiteSpace(item))
                {
                    Console.WriteLine("Please enter an item.");
                    continue;
                }

                Console.Write("What did it cost? ");
                string priceInput = Console.ReadLine();

                if (double.TryParse(priceInput, out double price))
                {
                    File.AppendAllText(path, $"{item} - {price}" + Environment.NewLine);
                    Console.WriteLine("Saved!");
                }
                else
                {
                    Console.WriteLine("Invalid price.");
                }
            }

            Console.WriteLine("\nFile saved here:");
            Console.WriteLine(Path.GetFullPath(path));
        }
    }
}