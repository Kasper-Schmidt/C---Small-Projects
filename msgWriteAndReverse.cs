using System;

namespace CoffeeNCode
{
    internal class MsgWriteAndReverse
    {
        public static void Run()
        {
            Console.Write("Enter a message: ");
            string message = Console.ReadLine();



            // Console.WriteLine(message);
            // Console.WriteLine(message[0]);



            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
            }



            Console.WriteLine();



            for (int i = message.Length - 1; i >= 0; i--)
            {
                Console.Write(message[i]);
            }



            Console.ReadLine();
        }
    }
}