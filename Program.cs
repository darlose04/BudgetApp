using System;

namespace BudgetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int income;
            int moneyAfterExpeditures;

            Console.Write("Enter your total monthly income: ");
            income = Convert.ToInt32(Console.ReadLine());

            Expenditures.Utilities();
            Expenditures.OtherCosts();

            moneyAfterExpeditures = Expenditures.totalUtilities - Expenditures.totalOtherCosts;
            Console.WriteLine(moneyAfterExpeditures);
        }

        
    }
}
