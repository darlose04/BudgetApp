using System;

namespace BudgetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int income;

            Console.Write("Enter your total monthly income: ");
            income = Convert.ToInt32(Console.ReadLine());

            Expenditures.Utilities();
        }
    }
}
