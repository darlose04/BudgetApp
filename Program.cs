using System;

namespace BudgetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int income;
            int moneyAfterExpeditures;
            int totalCosts;

            Console.Write("Enter your total monthly income: ");
            income = Convert.ToInt32(Console.ReadLine());

            Expenditures.Utilities();
            Expenditures.OtherCosts();

            totalCosts = Expenditures.totalUtilities + Expenditures.totalOtherCosts;
            moneyAfterExpeditures = income - totalCosts;

            Expenditures.PrintColorMessage(ConsoleColor.Green, "Your total expenses equal: " + totalCosts);
            Expenditures.PrintColorMessage(ConsoleColor.Green, "You have " + moneyAfterExpeditures + " dollars to spend on other things.");
        }
    }
}
