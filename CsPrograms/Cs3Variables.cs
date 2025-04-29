using System;

// Can have different file name: so even if there are same class names to different namespaces, 
//                               there won't be any conflict.

// namespace = organizes same-related code. Different namespaces can have same class names.
namespace CsPrograms // Matches Solution name.
{
    class Cs3Variables // PascalCase: matches file name.
    {
        public static void PrintVariables(string[] args)
        {
            Console.WriteLine("======== C# 3: Variables ========");


            // Variables' 2 steps: Declaration & Initialization

            int a; // Declaration
            a = 10; // Initialization

            int b = 5; // Declaration & Initialization

            int c = a + b;

            Console.WriteLine("\na: " + a);
            Console.WriteLine("b: " + b);
            Console.WriteLine("c: " + c);

            // Var names should be camelCase
            int stock = 12; // Whole int.
            double price = 30.99; // Decimal. Like floating point, but with more positions.
            bool inStock = true;
            bool isExpired = false;
            char currency = '$'; // Required to be enclosed with a single quote.
            String productName = "Chocolate Cake"; // "S"tring must be capitalized & must be with double quotes.

            Console.WriteLine("\nProduct: " + productName);
            Console.WriteLine("In Stock: " + inStock);
            Console.WriteLine("Is Expired: " + isExpired);
            Console.WriteLine("Stock: " + stock);
            Console.WriteLine("Price: " + currency + price);

            Console.ReadLine();

        }

    }
}


