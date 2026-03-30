using System;

namespace ForLoop
    {
    class Program
    {
        static void Main(string[] args)
        {
            for ( int i = 0; i <= 10; i++ )
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("----------------------");


            for (int j = 0; j <= 10; j+=2)
            {
                Console.WriteLine(j);
            }


            Console.WriteLine("----------------------");

            for (int k = 10; k >= 0; k--)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("Happy New Years!");







            Console.ReadKey();
        }
    }
}