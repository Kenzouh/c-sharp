using System;

namespace CsPrograms
{
    class Cs10Hypotenuse
    {
        public static void HypotenuseCalculator(string[] args)
        {
            Console.WriteLine("======== C# 10: Hypotenuse Calculator ========\n");

            Console.Write("Input a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            // Faster version: double c = Math.Sqrt((a * a) + (b & b));
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)); // Slightly slower, but correct.

            Console.WriteLine("==========================================");
            Console.WriteLine("||\t\t\t\t\t||");

            Console.WriteLine($"||\tHypotenuse: {c}\t||");
            
            Console.WriteLine("||\t\t\t\t\t||");
            Console.WriteLine("==========================================");
        }
    }

}