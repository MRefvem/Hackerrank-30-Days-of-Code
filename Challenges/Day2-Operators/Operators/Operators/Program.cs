using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());

            int tip_percent = Convert.ToInt32(Console.ReadLine());

            int tax_percent = Convert.ToInt32(Console.ReadLine());

            solve(meal_cost, tip_percent, tax_percent);
        }

        // Complete the solve function below.
        static double solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double tip_amount = (meal_cost * tip_percent) / 100;

            double tax_amount = (meal_cost * tax_percent) / 100;
            
            double total_cost = meal_cost + tip_amount + tax_amount;
            
            Console.WriteLine(Math.Round(total_cost));
            
            return total_cost;
        }

    }
}
