using System;

namespace CsPrograms
{
    class Cs6UserInput
    {
        public static void UserInput(string[] args)
        {
            try
            {
                Console.WriteLine("======== C# 6: User Input ========\n");

                Console.Write("Enter your username: ");
                String name = Console.ReadLine();

                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter your favorite food: ");
                String faveFood = Console.ReadLine();

                Console.WriteLine("\n====================================");
                Console.WriteLine("||\tNice to meet you, " + name + "!\t  ||");
                Console.WriteLine("||\tYou are " + age + " years old.\t  ||");
                Console.WriteLine("||\tYou like eating " + faveFood + ".\t  ||");
                Console.WriteLine("====================================");
            }

            catch(System.FormatException)
            {
                // Outputs upon receiving a string in variables declared as int.    
                Console.WriteLine("\nInput NUMBERS ONLY when the program asks how old are you.");
            }
        }
    }
}


