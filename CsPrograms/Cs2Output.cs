using System;

namespace CsPrograms
{
    class Cs2Output
    {


        public static void PrintOutput(string[] args)
        {
            // Method       String Literal = literally printing something to console.
            Console.WriteLine("======== C# 2: Output ========\n");


            Console.Write("Hey, "); // Doesn't print a new line.
            Console.WriteLine("how are you?"); // Prints a new line.

            // Commenting...

            /* Multi-line Comment
             *      
             *      Escape sequences:
             *      \a = Bell (alert) 
             *      \b = Backspace
             *      \f = Form feed
             *      \n = New line
             *      \r = Carriage return
             *      \t = Horizontal tab
             *      \v = Vertical tab
             *      \' = Single quotation mark
             *      \" = Double quotation mark
             *      \\ = Backslash
             *      \? = Literal question mark
             */

            Console.WriteLine("\t\"I'm fine!\"");

            Console.ReadKey(); // Prevents the program from ending until we type a key.

        }
    }
}
