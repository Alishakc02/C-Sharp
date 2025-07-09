using System;

namespace AlishaNCCLab
{
    class CaseConverter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            string converted = "";

            foreach (char c in input)
            {
                if (char.IsLower(c))
                {
                    converted += char.ToUpper(c);
                }
                else if (char.IsUpper(c))
                {
                    converted += char.ToLower(c);
                }
                else
                {
                    converted += c; // Keep non-alphabet characters unchanged
                }
            }

            Console.WriteLine("\nConverted string:");
            Console.WriteLine(converted);

            // Required Lab Info
            Console.WriteLine("\nLab No.: 2");
            Console.WriteLine("Name: Alisha Khatri");
            Console.WriteLine("Roll No./Section: 23/NCC");
        }
    }
}
