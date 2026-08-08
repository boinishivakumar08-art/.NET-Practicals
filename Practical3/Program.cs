using System;
using System.Collections.Generic;

namespace Practical3
{   
    class Expense
    {
        public string Name;
        public double Amount;
        public Expense(string name, double amount)
        {
            Name = name;
            Amount = amount;
        }
    }
    internal class Program
    {
        static List<Expense> expenses = new List<Expense>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- Expense Tracking System ---");
                Console.WriteLine("1. Add Expense");
                Console.WriteLine("2. View Expenses");
                Console.WriteLine("3. Calculate Total");
                Console.WriteLine("4. Exit");

                try
                {
                    Console.Write("Enter choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            AddExpense();
                            break;

                        case 2:
                            ViewExpenses();
                            break;

                        case 3:
                            CalculateTotal();
                            break;

                        case 4:
                            Console.WriteLine("Program Ended.");
                            return;

                        default:
                            Console.WriteLine("Invalid choice!");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Please enter a valid number.");
                }
            }
        }
        static void AddExpense()
        {
            try
            {
                Console.Write("Enter expense name: ");
                string name = Console.ReadLine();

                Console.Write("Enter amount: ");
                double amount = Convert.ToDouble(Console.ReadLine());

                if (amount <= 0)
                {
                    throw new Exception("Amount must be greater than 0.");
                }

                expenses.Add(new Expense(name, amount));

                Console.WriteLine("Expense added successfully!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid amount!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        static void ViewExpenses()
        {
            if (expenses.Count == 0)
            {
                Console.WriteLine("No expenses found.");
                return;
            }

            Console.WriteLine("\n--- Expenses ---");

            foreach (Expense expense in expenses)
            {
                Console.WriteLine(
                    "Name: " + expense.Name +
                    " | Amount: Rs." + expense.Amount);
            }
        }
        static void CalculateTotal()
        {
            double total = 0;

            foreach (Expense expense in expenses)
            {
                total += expense.Amount;
            }

            Console.WriteLine("Total Expense: Rs." + total);
        }
    }
}