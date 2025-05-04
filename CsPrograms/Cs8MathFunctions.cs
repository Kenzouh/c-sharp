using System;

namespace CsPrograms
{
    class Cs8MathFunctions
    {
        public static void MathFx(string[] args)
        {
            try
            {
                Console.WriteLine("======== C# 8: Math Functions ========\n");

                Console.Write("Input a number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Input a second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Input a third number:");
                double num3 = Convert.ToDouble(Console.ReadLine());

                // ============================== Power ==============================


                Console.WriteLine("\n\n==== Power ====\n\n");

                                           // base, power
                double powerNum1_1 = Math.Pow(num1, num2);
                double powerNum1_2 = Math.Pow(num1, num3);

                double powerNum2_1 = Math.Pow(num2, num1);
                double powerNum2_2 = Math.Pow(num2, num3);

                double powerNum3_1 = Math.Pow(num3, num1);
                double powerNum3_2 = Math.Pow(num3, num2);

                Console.WriteLine($"Power ({num1} ^ {num2})\t\t: {powerNum1_1}");
                Console.WriteLine($"Power ({num1} ^ {num3})\t\t: {powerNum1_2}");

                Console.WriteLine($"Power ({num2} ^ {num1})\t\t: {powerNum2_1}");
                Console.WriteLine($"Power ({num2} ^ {num3})\t\t: {powerNum2_2}");

                Console.WriteLine($"Power ({num3} ^ {num1})\t\t: {powerNum3_1}");
                Console.WriteLine($"Power ({num3} ^ {num2})\t\t: {powerNum3_2}");


                // ============================== Square Root ==============================


                Console.WriteLine("\n\n==== Square Root ====\n\n");

                double sqrt1 = Math.Sqrt(num1);
                double sqrt2 = Math.Sqrt(num2);
                double sqrt3 = Math.Sqrt(num3);

                Console.WriteLine($"Square Root ({num1}) \t: {sqrt1}");
                Console.WriteLine($"Square Root ({num2}) \t: {sqrt2}");
                Console.WriteLine($"Square Root ({num3}) \t: {sqrt3}");


                // ============================== Absolute ==============================


                Console.WriteLine("\n\n==== Absolute ====\n\n"); // Turns negative to its positive form.

                double absolute1 = Math.Abs(num1);
                double absolute2 = Math.Abs(num2);
                double absolute3 = Math.Abs(num3);

                Console.WriteLine($"Absolute ({num1})\t\t: {absolute1}");
                Console.WriteLine($"Absolute ({num2})\t\t: {absolute2}");
                Console.WriteLine($"Absolute ({num3})\t\t: {absolute3}");


                // ============================== Round ==============================


                Console.WriteLine("\n\n==== Round ====\n\n");

                double round1 = Math.Round(num1);
                double round2 = Math.Round(num2);
                double round3 = Math.Round(num3);

                Console.WriteLine($"Round ({num1})\t\t: {round1}");
                Console.WriteLine($"Round ({num2})\t\t: {round2}");
                Console.WriteLine($"Round ({num3})\t\t: {round3}");


                // ============================== Ceiling ==============================


                Console.WriteLine("\n\n==== Ceiling ====\n\n");

                double ceiling1 = Math.Ceiling(num1);
                double ceiling2 = Math.Ceiling(num2);
                double ceiling3 = Math.Ceiling(num3);

                Console.WriteLine($"Ceiling ({num1})\t\t: {ceiling1}");
                Console.WriteLine($"Ceiling ({num2})\t\t: {ceiling2}");
                Console.WriteLine($"Ceiling ({num3})\t\t: {ceiling3}");


                // ============================== Floor ==============================


                Console.WriteLine("\n\n==== Floor ====\n\n");

                double floor1 = Math.Floor(num1);
                double floor2 = Math.Floor(num2);
                double floor3 = Math.Floor(num3);

                Console.WriteLine($"Floor ({num1})\t\t: {floor1}");
                Console.WriteLine($"Floor ({num2})\t\t: {floor2}");
                Console.WriteLine($"Floor ({num2})]\t\t: {floor3}");


                // ============================== Max ==============================


                Console.WriteLine("\n\n==== Max ====\n\n");

                                       // ONLY 2 ARGUMENTS!
                double max1_1 = Math.Max(num1, num2);
                double max1_2 = Math.Max(num1, num3);

                double max2_1 = Math.Max(num2, num1);
                double max2_3 = Math.Max(num2, num3);

                double max3_1 = Math.Max(num3, num1);
                double max3_2 = Math.Max(num3, num2);

                Console.WriteLine($"Max ({num1}, {num2})\t\t: {max1_1}");
                Console.WriteLine($"Max ({num1}, {num2})\t\t: {max1_2}");

                Console.WriteLine($"Max ({num2}, {num1})\t\t: {max2_1}");
                Console.WriteLine($"Max ({num2}, {num3})\t\t: {max2_3}");

                Console.WriteLine($"Max ({num3}, {num1})\t\t: {max3_1}");
                Console.WriteLine($"Max ({num3}, {num2})\t\t: {max3_2}");


                // ============================== Min ==============================

                Console.WriteLine("\n\n==== Min ====\n\n");

                double min1_1 = Math.Min(num1, num2);
                double min1_2 = Math.Min(num1, num3);

                double min2_1 = Math.Min(num2, num1);
                double min2_2 = Math.Min(num2, num3);

                double min3_1 = Math.Min(num3, num1);
                double min3_2 = Math.Min(num3, num2);

                Console.WriteLine($"Min ({num1}, {num2})\t\t: {min1_1}");
                Console.WriteLine($"Min ({num1}, {num2})\t\t: {min1_2}");

                Console.WriteLine($"Min ({num2}, {num1})\t\t: {min2_1}");
                Console.WriteLine($"Min ({num2}, {num3})\t\t: {min2_2}");

                Console.WriteLine($"Min ({num3}, {num1})\t\t: {min3_1}");
                Console.WriteLine($"Min ({num3}, {num1})\t\t: {min3_2}");


            }

            catch (System.FormatException)
            {
                Console.WriteLine("\nPlease, enter numbers only.");
            }


        }
    }
}