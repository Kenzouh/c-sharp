using System;

namespace CsPrograms
{
    class Cs11StringMethods
    {
        public static void StringMethods(string[] args)
        {
            String ceoName = "Volt Jenkins";
            String phoneNumber = "61 453 229 765"; // Fake Australian Number.

            Console.WriteLine("======== C# 11: String Methods ========\n");

            Console.WriteLine($"CEO Name: {ceoName}\n");

            ceoName = ceoName.ToUpper();
            Console.WriteLine($"ceoName.ToUpper: {ceoName}");

            ceoName = ceoName.ToLower();
            Console.WriteLine($"ceoname.ToLower: {ceoName}");

            Console.WriteLine("\n======================================\n");

            Console.WriteLine($"Phone Number: {phoneNumber}\n");

            phoneNumber = phoneNumber.Insert(0, "+");
            Console.WriteLine($"phoneNumber.Insert: {phoneNumber}");

            phoneNumber = phoneNumber.Replace(" ", "-");
            Console.WriteLine($"phoneNumber.Replace: {phoneNumber}\n");

            // Subsection.
            String countryCode = phoneNumber.Substring(0, 3);
            Console.WriteLine($"Country Code: {countryCode}");

            String mobilePrefix = phoneNumber.Substring(4, 3);
            Console.WriteLine($"Mobile Prefix: {mobilePrefix}");

            String localNumber = phoneNumber.Substring(8);
            Console.WriteLine($"Local Number: {localNumber}");

            Console.WriteLine("\n======================================\n");

            // Property, but not a method.
            Console.WriteLine($"ceoName.Length: {ceoName.Length}");
        }
    }
}