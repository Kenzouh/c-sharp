using System;

namespace CsPrograms
{
    class Cs12IfStatements
    {
        public static void IfStatements(string[] args)
        {
            try
            {
                Console.WriteLine("======== C# 12: If Else ========\n");

                Console.Write("Enter your name:");
                String name = Console.ReadLine();

                Console.Write("Enter your age (e.g.: 1.25): ");
                double grade = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Grade: {grade}\n");


                if (grade > 5.00 || grade < 0)
                {
                    Console.WriteLine("Grade must not be less than 1.00–5.00 or \"INC\" only.");
                }

                else if (grade > 4.00)
                {
                    Console.WriteLine("Grade Letter: F");
                    Console.WriteLine("Equivalence: Below 60%");
                    Console.WriteLine("GPA Equivalence: 0.000");
                    Console.WriteLine("Description: Fail");
                }

                else if (grade > 3.00)
                {
                    Console.WriteLine("Grade Letter: D");
                    Console.WriteLine("Equivalence: -");
                    Console.WriteLine("GPA Equivalence: -");
                    Console.WriteLine("Description: Conditional");
                }

                else if (grade > 2.75)
                {
                    Console.WriteLine("Grade Letter: C-");
                    Console.WriteLine("Equivalence: 75.00–77.74%");
                    Console.WriteLine("GPA Equivalence: 1.000-1.374");
                    Console.WriteLine("Description: Pass");
                }

                else if (grade > 2.50)
                {
                    Console.WriteLine("Grade Letter: C");
                    Console.WriteLine("Equivalence: 78–80%");
                    Console.WriteLine("GPA Equivalence: 1.375-1.1749");
                    Console.WriteLine("Description: Pass");
                }

                else if (grade > 2.25)
                {
                    Console.WriteLine("Grade Letter: C+");
                    Console.WriteLine("Equivalence: 81–83%");
                    Console.WriteLine("GPA Equivalence: 1.750-2.124");
                    Console.WriteLine("Description: Satisfactory");
                }

                else if (grade > 2.00)
                {
                    Console.WriteLine("Grade Letter: B-");
                    Console.WriteLine("Equivalence: 84–86%");
                    Console.WriteLine("GPA Equivalence: 2.125-2.499");
                    Console.WriteLine("Description: Satisfactory");
                }

                else if (grade > 1.75)
                {
                    Console.WriteLine("Grade Letter: B");
                    Console.WriteLine("Equivalence: 87–89%");
                    Console.WriteLine("GPA Equivalence: 2.500-2.874");
                    Console.WriteLine("Description: Good");
                }

                else if (grade > 1.50)
                {
                    Console.WriteLine("Grade Letter: B+");
                    Console.WriteLine("Equivalence: 90–92%");
                    Console.WriteLine("GPA Equivalence: 2.875-3.249");
                    Console.WriteLine("Description: Good");
                }

                else if (grade > 1.25)
                {
                    Console.WriteLine("Grade Letter: -");
                    Console.WriteLine("Equivalence: 93–95%");
                    Console.WriteLine("GPA Equivalence: 3.250-3.624");
                    Console.WriteLine("Description: Very Good");
                }

                else if (grade > 1.00)
                {
                    Console.WriteLine("Grade Letter: A");
                    Console.WriteLine("Equivalence: 96–98%");
                    Console.WriteLine("GPA Equivalence: 3.625–3.999");
                    Console.WriteLine("Description: Very Good");
                }


                else if (grade == 1.00)
                {
                    Console.WriteLine("Grade Letter: A+");
                    Console.WriteLine("Equivalence: 99–100%");
                    Console.WriteLine("GPA Equivalence: 4.000");
                    Console.WriteLine("Description: Excellent");
                }

                else 
                {
                    Console.WriteLine("Grade Letter: INC");
                }
            }

            catch (System.FormatException) 
            {
                Console.WriteLine("Please, enter numbers only for grades.");
            }

        }
    }
}