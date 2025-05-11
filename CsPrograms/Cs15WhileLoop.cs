using System;
using System.Xml.Linq;

namespace CsPrograms
{
    class Cs15WhileLoop
    {
        public static void WhileLoop(string[] args)
        {
            Console.WriteLine("======== C# 15: While Loop ========\n");

            // While Loop = repeats some code while some condition remains true.

            Console.Write("Insert Name: ");
            String name = Console.ReadLine();

            
            while (name == "")
            {
                Console.Write("Insert Name: ");
                name = Console.ReadLine();
            }


            Console.Write("\nInsert Age: ");
            int age; // Initialize only.
            String input;

            do
            {
                Console.Write("Insert Age: ");
                input = Console.ReadLine();
            }
                         // Checks if string.
            while (!int.TryParse(input, out age) || age < 0);


            if (age == 1)
            {
                Console.WriteLine($"\nHi, {name}! You are {age} year old!");
            }
            
            else 
            {
                Console.WriteLine($"\nHi, {name}! You are {age} years old!");
            }
            
        }
    }

}