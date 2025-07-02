using System;

namespace Alisha03_CSIT_6th
{
    class DigitChecker
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            CheckDigitCategory(num1, "First");
            CheckDigitCategory(num2, "Second");
        }

        static void CheckDigitCategory(int number, string label)
        {
            int absNumber = Math.Abs(number); // Handle negative numbers

            if (absNumber >= 0 && absNumber <= 9)
            {
                Console.WriteLine($"{label} number is a Single-digit number.");
            }
            else if (absNumber >= 10 && absNumber <= 99)
            {
                Console.WriteLine($"{label} number is a Double-digit number.");
            }
            else if (absNumber >= 100 && absNumber <= 999)
            {
                Console.WriteLine($"{label} number is a Triple-digit number.");
            }
            else
            {
                Console.WriteLine($"{label} number is a Multiple-digit number (more than 3 digits).");
            }
        }
    }
}
