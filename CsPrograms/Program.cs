using System;

namespace CsPrograms // Matches Solution Name
{
    class Program // Matches File Name
    {
        // Main method: entry point for where a program begins.
        public static void Main(string[] args)
        {
            try
            {
                // Main method body.
                Console.WriteLine("=============== C# Programs ===============\n\n");

                Console.WriteLine("Hello there, and welcome!");
                Console.Write("Pick a number [1-100]: ");
                Console.Beep();

                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Cs1Printing.PrintStatements(args);
                        break;

                    case 2:
                        // Calling Cs2Output.PrintOutput()
                        Cs2Output.PrintOutput(args);
                        break;

                    case 3:
                        Cs3Variables.PrintVariables(args);
                        break;

                    case 4:
                        Cs4Constant.ConstantVars(args);
                        break;

                    case 5:
                        Cs5TypeCasting.TypeCasting(args);
                        break;

                    case 6:
                        Cs6UserInput.UserInput(args);
                        break;

                    case 7:
                        Cs7Operators.ArithmeticOperators(args);
                        break;

                    case 8:
                        Cs8MathFunctions.MathFx(args);
                        break;

                    case 9:
                        Cs9RandomNumbers.RandNums(args);
                        break;

                    case 10:
                        Cs10Hypotenuse.HypotenuseCalculator(args);
                        break;

                    case 11:
                        Cs11StringMethods.StringMethods(args);
                        break;

                    case 12:
                        Cs12IfStatements.IfStatements(args);
                        break;

                    case 13:
                        Cs13Switch.switchCase(args);
                        break;

                    case 14:
                        Cs14LogicalOperators.logicOperators(args);
                        break;

                    case 15:
                        Cs15WhileLoop.WhileLoop(args);
                        break;

                    case 16:
                        Cs16ForLoop.ForLoop(args);
                        break;

                    case 17:
                        Cs17NestedLoop.Nested(args);
                        break;

                    case 100:
                        Practice.PracticeCode(args);
                        break;

                    

                    default:
                        Console.WriteLine("Input Nos. 1 to 10 only.");
                        break;
                }
            }
            catch (System.FormatException) 
            {
                Console.WriteLine("\nType a NUMBER only from [1–100].");
            }

        }
    }
}