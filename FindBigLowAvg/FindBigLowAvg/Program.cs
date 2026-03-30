using System;

namespace FindBigLowAvg
    {
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 1, 9, 14, 21, -6, 32 };

            GetMax(numbers);
            GetMin(numbers);
            GetAvg(numbers);
            GetTotal(numbers);



        }

        static void GetMax(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {                 
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine($"Highest number: {max}");
        }


        static void GetMin(int[] numbers)
        {
            int min = numbers[0];
            for (int i = 1; i < numbers.Length; i ++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine($"Smallest number: {min}");
        }

        static void GetAvg(int[] numbers)
        {
            double sum = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine($"Average number: {sum / numbers.Length}");
        }

        static void GetTotal(int[] numbers)
        {
            double sum = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine($"Total sum: {sum}");
        }
    }
}