using System;

namespace CsPrograms
{
    class Cs14LogicalOperators
    {
        public static void logicOperators(string[] args)
        {
            // Logical Operators = checks if 2 or more conditions are true/false.
            // && = and       || = or

            Console.WriteLine("======== C# 14: Logical Operators ========\n");

            Console.Write("Your total cost: $");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Are you a senior[\"Y\" if yes | \"N\" if no]: ");
            String senior = Console.ReadLine();
            senior = senior.ToUpper();

            Console.Write("Are you a student[\"Y\" if yes | \"N\" if no]: ");
            String student = Console.ReadLine();
            student = student.ToUpper();

            Console.WriteLine("");

            // Must be senior/student, and must pay $1000 or more.
            if ((senior == "Y" && price >= 1000) || (student == "Y" && price >= 1000))
            {
                // 10% discount formula
                double discountedPrice = price - (price * 0.10);

                Console.WriteLine("You are legible of getting a 10% discount!\n");

                Console.WriteLine($"Original Price: ${price}");
                Console.WriteLine($"Total Discounted Price: ${discountedPrice}");
            }

            // Must be senior / student / be paying $1000 or more.
            else if (senior == "Y" || student == "Y" || price >= 1000)
            {
                // 5% discount formula
                double discountedPrice = price - (price * 0.05);

                Console.WriteLine("You are legible of getting a 5% discount!\n");

                Console.WriteLine($"Original Price: ${price}");
                Console.WriteLine($"Total Discounted Price: ${discountedPrice}");
            }

            // Not a senior/student, and didn't have $1000 or more as the total price.
            else 
            {
                Console.WriteLine("No discounts approved.\n");

                Console.WriteLine($"Total Price: ${price}");
            }
        }
    }
}