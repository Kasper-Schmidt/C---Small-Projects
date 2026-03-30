using System;

namespace BankSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = 1000;
            bool running = true;

            while (running)
            {
                ShowMenu();
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    balance = Deposit(balance);
                }
                else if (choice == "2")
                {
                    balance = Withdraw(balance);
                }
                else if (choice == "3")
                {
                    ShowBalance(balance);
                }
                else if (choice == "4")
                {
                    running = false;
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("\n1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show balance");
            Console.WriteLine("4. Exit");
            Console.Write("Choose: ");
        }

        static double Deposit(double balance)
        {
            Console.Write("Enter amount to deposit: ");

            if (double.TryParse(Console.ReadLine(), out double amount) && amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount}");
                Console.WriteLine($"New balance: {balance}");
            }
            else
            {
                Console.WriteLine("Invalid amount.");
            }

            return balance;
        }

        static double Withdraw(double balance)
        {
            Console.Write("Enter amount to withdraw: ");

            if (double.TryParse(Console.ReadLine(), out double amount) && amount > 0)
            {
                if (amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine($"Withdrew: {amount}");
                    Console.WriteLine($"New balance: {balance}");
                }
                else
                {
                    Console.WriteLine("Not enough money.");
                }
            }
            else
            {
                Console.WriteLine("Invalid amount.");
            }

            return balance;
        }

        static void ShowBalance(double balance)
        {
            Console.WriteLine($"Current balance: {balance}");
        }
    }
}