using System;

namespace CsPrograms
{
    class Cs4Constant
    {
        public static void ConstantVars(string[] args)
        {

            Console.WriteLine("======== C# 4: Constant ========\n");

            // Constant (const) = immutable values (values will never change; the same forever).
            //                  = immutable values are known at compile time.

            const int userId = 15;
            const string deptCode = "IT134";
            const string operationCode = "Golf Oscar"; // NATO phonetic alphabet for "Go"

            Console.WriteLine("Welcome, Employee No. " + userId + "!");
            Console.WriteLine("Your deptCode is: [" + deptCode + "]\n");
            Console.WriteLine("Operation \"" + operationCode + "\" has commenced.");

            Console.ReadKey();
        }
    }
}