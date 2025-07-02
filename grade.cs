using System;
namespace Alisha03_CSIT_6th
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter your marks (0-100): ");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks >= 90 && marks <= 100)
            {
                Console.WriteLine("Grade: A");
            }
            else if (marks >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (marks >= 70)
            {
                Console.WriteLine("Grade: C");
            }
            else if (marks >= 60)
            {
                Console.WriteLine("Grade: D");
            }
            else if (marks >= 50)
            {
                Console.WriteLine("Grade: E");
            }
            else if (marks >= 0)
            {
                Console.WriteLine("Grade: F");
            }
            else
            {
                Console.WriteLine("Invalid input. Marks should be between 0 and 100.");
            }
        }
    }
}
