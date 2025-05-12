using System;

namespace CsPrograms
{
    class Cs16ForLoop
    {
        public static void ForLoop(string[] args)
        {
            Console.WriteLine("======== C# 16: For Loop ========\n");

            // for loop = repeats some code a FINITE amount of times.

            Console.WriteLine("int i = 0; i < 10; i++\n");

            // Counter (index); Condition; Incrementation/Decrementation
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i}");
            }

            // =================================================================================

            Console.WriteLine("\nint i = 1; i <= 10; i++\n");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            // =================================================================================

            Console.WriteLine("\nint i = 1; i <= 10; i += 2\n");

            for (int i = 1; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }

            // =================================================================================

            Console.WriteLine("\nint i = 0; i <= 10; i += 2\n");

            for (int i = 2; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }

            // =================================================================================

            Console.WriteLine("\nint i = 10; i >= 0; i--\n");

            for (int i = 10; i >=0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }

}