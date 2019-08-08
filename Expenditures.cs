using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetApp
{
    static class Expenditures
    {
        public static void Utilities()
        {
            int totalUtilities;
            int internetCable;
            int phone;
            int electric;
            int mortgageOrRent;
            int gas;
            int water;

            Console.Write("Enter your internet/cable bill: ");
            internetCable = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your phone bill: ");
            phone = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your electric bill: ");
            electric = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your monthly rent or mortgage: ");
            mortgageOrRent = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your gas (heating) bill: ");
            gas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your water bill: ");
            water = Convert.ToInt32(Console.ReadLine());

            totalUtilities = internetCable + phone + electric + mortgageOrRent + gas + water;

            PrintColorMessage(ConsoleColor.Green, "Your total monthly utilities cost is: " + totalUtilities);
        }

        public static void OtherCosts()
        {
            int totalOtherCosts;
            int groceries;
            int carExpenses;

            Console.Write("Enter total amount spent on groceries: ");
            groceries = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter car related expenses (gas, insurance, maintenance): ");
            carExpenses = Convert.ToInt32(Console.ReadLine());

            totalOtherCosts = groceries + carExpenses;
            PrintColorMessage(ConsoleColor.Green, "Costs in addition to utilities amounts to: " + totalOtherCosts);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
