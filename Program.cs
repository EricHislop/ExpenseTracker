using System;
using System.IO;

namespace ExpenseTracker
{
    class Program
    {


        static public void TrackExpense()
        {
            Console.WriteLine("Enter Amount");
            //Track amount spend 
            double amount = double.Parse(Console.ReadLine());

            //Track place spent
            Console.WriteLine("Enter Place");
            string place = Console.ReadLine();

            //Track date spend
            Console.WriteLine("Enter day as number");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter month as number");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter year as number");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine(amount);
            Console.WriteLine(place);
            Console.WriteLine($"{day}.{month}.{year}");

            string expense = $"{amount},{place},{day},{month},{year}";


            //Store amount,place,date 
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("data.txt", true))
            {
                file.WriteLine(expense);
            }
        }

        static public void ReturnExpenses()
        {
            //Return all amounts, places, and dates
            using (StreamReader sr = new StreamReader("data.txt"))
            {
                string line = sr.ReadToEnd();
                Console.WriteLine(line);
            }
        }
        static void Main(string[] args)
        {


            Console.WriteLine("Track your expenses");
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter 1: For new expenses \r\nEnter 2: To list expenses ");
                    int task = int.Parse(Console.ReadLine());
                    if (task == 1)
                    {
                        TrackExpense();
                    }
                    if (task == 2)
                    {
                        ReturnExpenses();
                    }

                }
                catch (System.Exception)
                {
                    Console.WriteLine("Oh no");
                }
            };
        }
    }
}
