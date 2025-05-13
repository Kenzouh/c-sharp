using System;

namespace CsPrograms
{
    class Cs17NestedLoop
    {
        public static void Nested(string[] args)
        {
            Console.WriteLine("======== C# 17: Nested Loop ========\n");

            // Nested loop = loop inside of a loop. Can be for or while loop.
            //               Uses vary, used a lot in sorting algorithms.

            Console.Write("How many rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many columns: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a single letter/symbol: ");
            char symbol = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++) // j = naming convention since it comes after "i".
                {
                    Console.Write(symbol + " ");
                }

                Console.WriteLine(""); // Moving to a next line.
            }
           
        }
    }
}