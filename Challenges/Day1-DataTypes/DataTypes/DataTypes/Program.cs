using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // Declare second integer, double, and String variables.
            int integerVar = 0;
            double doubleVar = 0.0;
            string stringVar = "";
            // Read and save an integer, double, and String to your variables.
            integerVar = Convert.ToInt32(Console.ReadLine());
            doubleVar = Convert.ToDouble(Console.ReadLine());
            stringVar = Console.ReadLine();
            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i + integerVar);
            // Print the sum of the double variables on a new line.
            Console.WriteLine(d + doubleVar);
            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s + stringVar);
        }
    }
}
