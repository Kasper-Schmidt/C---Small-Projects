using System;

namespace StringCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            string correctUsername = "Kasper";
            string correctPassword = "Schmidt";

            Console.WriteLine("What's the username? ");
            string username = Console.ReadLine();

            Console.WriteLine("What's the correct password? ");
            string password = Console.ReadLine();

            if (username == correctUsername && password == correctPassword)
            {
                Console.WriteLine("Login succesfull");
            }
            else
            {
                Console.WriteLine("The login was incorrect");
            }


        }
    }
}