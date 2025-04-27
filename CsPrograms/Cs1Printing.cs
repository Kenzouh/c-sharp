// See https://aka.ms/new-console-template for more information

using System;

namespace CsPrograms // Matches Solution Name
{
    class Cs1Printing // Matches File Name
    {
        public static void PrintStatements(string[] args)
        {

            Console.WriteLine("======== C# 1: Printing ========\n\n");

            Console.WriteLine("Hello there, and welcome!");
            Console.WriteLine("This is my very first program.");

            Console.Beep();

            Console.WriteLine("\nPress Enter to exit the program.");
            Console.ReadLine(); // Waits for user input since the program closes too quickly.
        }

    }

}
