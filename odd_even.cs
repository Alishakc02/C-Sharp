using System;

namespace Alisha03_CSIT_6th
{
    class EvenOddPrinter
    {
        static void Main()
        {
            Console.WriteLine("Even numbers from 100 to 0 (in reverse):");
            for (int i = 100; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine("\n\nOdd numbers from 1 to 99 (in order):");
            for (int i = 1; i <= 99; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine(); // for clean line at the end
        }
    }
}
