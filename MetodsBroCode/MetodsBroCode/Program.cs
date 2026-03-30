using System;

namespace MetodsBroCode
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the name of the birthday person: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the age of the birthday person: ");
            int age = Convert.ToInt32(Console.ReadLine());


            singHappyBirthday(name, age);
            singHappyBirthday(name, age);
            singHappyBirthday(name, age);


            Console.WriteLine("----------------------");


            for (int i = 0; i < 3; i++)
            {
                singHappyBirthday(name, age);
            }






            Console.ReadKey();
        }

        static void singHappyBirthday(String name, int age)
        {
            Console.WriteLine();
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine($"Happy birthday dear {name}!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("You are turning old");
            Console.WriteLine($"Exactly {age} years old!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine();
        }

    }
}