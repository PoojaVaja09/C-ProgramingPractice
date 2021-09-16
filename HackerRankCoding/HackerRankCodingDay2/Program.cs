using System;

namespace HackerRankCodingDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            double mealCost = Convert.ToDouble(Console.ReadLine());
            int tipPercent = Convert.ToInt32(Console.ReadLine());
            
            int taxPercent = Convert.ToInt32(Console.ReadLine());
            double n = solve(mealCost, tipPercent, taxPercent);
            Console.WriteLine(n);
            Console.ReadLine();


        }

        static double solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double tip_perc = tip_percent / 100.0;

            double tip = ((meal_cost) * (tip_percent / 100.0));
            double tax = ((meal_cost) * (tax_percent / 100.0));
            double mealCost = meal_cost + tip + tax;
            double newMealCost = Math.Round(mealCost);
            return newMealCost;
        }
    }
}
