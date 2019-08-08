using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetApp
{
    public static class Expenditures
    {
        public static int totalUtilities;
        public static int internetCable;
        public static int phone;
        public static int electric;
        public static int mortgageOrRent;
        public static int gas;
        public static int water;

        public static void Utilities()
        {
            

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

        public static int totalOtherCosts;
        public static int groceries;
        public static int carExpenses;

        public static void OtherCosts()
        {
            

            Console.Write("Enter total amount spent on groceries: ");
            groceries = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter car related expenses (gas, insurance, maintenance): ");
            carExpenses = Convert.ToInt32(Console.ReadLine());

            totalOtherCosts = groceries + carExpenses;
            PrintColorMessage(ConsoleColor.Green, "Costs in addition to utilities amounts to: " + totalOtherCosts);

            
        }

        public static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
