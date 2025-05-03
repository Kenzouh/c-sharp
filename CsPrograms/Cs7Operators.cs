using System;

namespace CsPrograms
{
    class Cs7Operators
    {
        public static void ArithmeticOperators(string[] args)
        {
            Console.WriteLine("======== C# 7: Operators ========\n");

            int num1 = 85;

            Console.WriteLine("num1: " + num1 + "\n");

            // ============================== Addition ==============================

            Console.WriteLine("\n==== Addition ====\n");

            num1 = num1 + 8; // Standard Way
            Console.WriteLine("\nnum1 = num1 + 8\t\t:\t" + num1);

            num1 += 8; // Shortcut
            Console.WriteLine($"num1 += 8\t\t:\t{num1}");

            num1++; // Incrementation
            Console.WriteLine($"num1++\t\t\t:\t{num1}");

            // ============================== Subtraction ==============================

            int num2 = 150;

            Console.WriteLine("\n\n==== Subtraction ====\n\n");

            Console.WriteLine($"num2: {num2}\n");

            num2 = num2 - 5;
            Console.WriteLine($"num2 = num2 - 5\t\t:\t{num2}");

            num2 -= 5;
            Console.WriteLine($"num2 -= 5\t\t:\t{num2}");

            num2--;
            Console.WriteLine($"num2--\t\t\t:\t{num2}");

            // ============================== Multiplication ==============================

            int num3 = 20;

            Console.WriteLine("\n\n==== Multiplication ====\n\n");

            Console.WriteLine($"num3: {num3}\n");

            num3 = num3 * 2;
            Console.WriteLine($"num3 = num3 * 2\t\t:\t{num3}");

            num3 *= 4;
            Console.WriteLine($"num3 *= 3\t\t:\t{num3}");

            // ============================== Division ==============================

            int num4 = 80;

            Console.WriteLine("\n\n==== Division ====\n\n");

            Console.WriteLine($"num4: {num4}\n");

            num4 = num4 / 4;
            Console.WriteLine($"num4 = num4 / 4\t\t:\t{num4}");

            num4 /= 2;
            Console.WriteLine($"num4 /= 2\t\t:\t{num4}");

            // ============================== Modulus ==============================

            int num5 = 500;

            Console.WriteLine("\n\n==== Modulus ====\n\n");

            int remainder = num5 % 2;
            Console.WriteLine($"remainder = num5 % 2\t:\t{remainder}");

            remainder = num5 % 8;
            Console.WriteLine($"remainder = num5 % 8\t:\t{remainder}");
        }
    }
}