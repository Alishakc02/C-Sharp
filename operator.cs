using System;

namespace Alisha03_CSIT_6th
{
    class switch_operator
    {
        static void Main()
        {
            // Take first number
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            // Take second number
            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Take operator
            Console.Write("Enter operator (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());

            // Perform operation using switch
            double result;

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine("Result: " + result);
                    break;

                case '-':
                    result = num1 - num2;
                    Console.WriteLine("Result: " + result);
                    break;

                case '*':
                    result = num1 * num2;
                    Console.WriteLine("Result: " + result);
                    break;

                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine("Result: " + result);
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operator entered.");
                    break;
            }
        }
    }
}
