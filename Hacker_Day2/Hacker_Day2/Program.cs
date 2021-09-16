using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker_Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter mealcost:");
            double meal_cost = Convert.ToDouble(Console.ReadLine());

            int tip_percent = Convert.ToInt32(Console.ReadLine());

            int tax_percent = Convert.ToInt32(Console.ReadLine());

            var n = solve(meal_cost, tip_percent, tax_percent);
            Console.WriteLine(n);
            Console.ReadLine();
        }

        static double solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double tip = (meal_cost) * (tip_percent / 100);
            double tax = (meal_cost) * (tax_percent / 100);
            double mealCost = meal_cost + tip + tax;
            var newMealCost =  Math.Round(mealCost);
            return newMealCost;
        }
    }
}
