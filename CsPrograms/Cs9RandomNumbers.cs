using System;
using System.Transactions;

namespace CsPrograms
{
    class Cs9RandomNumbers
    {
        public static void RandNums(string[] args)
        {
            Console.WriteLine("======== C# 9: Random Numbers ========\n");

            // Not true random numbers; but TRUE PSEUDONUMBERS.

            // Object instantiation
            //     random can be called anything.
            Random random = new Random();

            // random (object) can be reused multiple times
            int num1 = random.Next();
            Console.WriteLine($"num1 ({num1.GetType()}): {num1}");

            // Range 1–6
            int num2 = random.Next(1, 7);
            Console.WriteLine($"num2 ({num2.GetType()}): {num2}");

            // Range 1–50, then add 200
            int num3 = random.Next(1, 51) + 200;
            Console.WriteLine($"num3 ({num3.GetType()}): {num3}");

            // Generates double decimal number.
            double num4 = random.NextDouble();
            Console.WriteLine($"num4 ({num4.GetType()}): {num4}");
        }
    }
}