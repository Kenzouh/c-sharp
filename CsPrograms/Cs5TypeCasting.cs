using System;

namespace CsPrograms
{
    class Cs5TypeCasting
    {
        public static void TypeCasting(string[] args) 
        {
            Console.WriteLine("======== C# 5: Type Casting ========\n");

            // Type Casting: converting to a different data type.
            //               Good practice for accepting user input (String).

            try 
            {
                // ToInt (Method): Truncates any decimal portion.
                double price = 29.99;
                int updatedPrice = Convert.ToInt32(price);

                // ToDouble (Method): Converts to double.
                int cupOfMilk = 1;
                double updatedCupOfMilk = Convert.ToDouble(cupOfMilk); // If double doesn't contain decimal portions, it won't print out the 0s.
                double updatedCupOfMilk2 = Convert.ToDouble(cupOfMilk) + 0.5;

                // ToString (Method): Converts to string.
                int phoneNumber = 924285214;
                String updatedPhoneNumber = Convert.ToString(phoneNumber);

                // ToChar (Method): Converts to character.
                String currency = "$";
                char updatedCurrency = Convert.ToChar(currency);

                // ToBoolean (Method): Converts to Boolean.
                String forSale = "true";
                bool updatedForSale = Convert.ToBoolean(forSale);

                String isExpired = "false";
                bool updatedIsExpired = Convert.ToBoolean(isExpired);

                Console.WriteLine("Welcome to the Cake Shop!\n");

                Console.WriteLine("Product of the day: Chocolate Cake\n");

                Console.WriteLine("Price (" + price.GetType() + "): " + price);
                Console.WriteLine("Updated Price (" + updatedPrice.GetType() + "): " + updatedPrice);

                Console.WriteLine("\nCup of Milk (" + cupOfMilk.GetType() + "): " + cupOfMilk);
                Console.WriteLine("Updated Cup of Milk (" + updatedCupOfMilk.GetType() + "): " + updatedCupOfMilk);
                Console.WriteLine("Updated Cup of Milk 2 (" + updatedCupOfMilk2.GetType() + "): " + updatedCupOfMilk2);

                Console.WriteLine("\nPhone Number (" + phoneNumber.GetType() + "): " + phoneNumber);
                Console.WriteLine("Updated Phone Number (" + updatedPhoneNumber.GetType() + "): " + updatedPhoneNumber);

                Console.WriteLine("\nCurrency (" + currency.GetType() + "): " + currency);
                Console.WriteLine("Updated Currency (" + updatedCurrency.GetType() + "): " + updatedCurrency);

                Console.WriteLine("\nFor Sale (" + forSale.GetType() + "): " + forSale);
                Console.WriteLine("Updated For Sale (" + updatedForSale.GetType() + "): " + updatedForSale);
                Console.WriteLine("Is Expired (" + isExpired.GetType() + "): " + isExpired);
                Console.WriteLine("Updated Is Expired (" + updatedIsExpired.GetType() + "): " + updatedIsExpired);
            }

            catch(System.FormatException) 
            {
                Console.WriteLine("Incorrect value/format: Ensure that your formatting is correct.");
            }

        }
    }
}

