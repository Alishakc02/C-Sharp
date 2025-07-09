using System;

namespace AlishaNCCLab
{
    class JaggedArrayDemo
    {
        static void Main(string[] args)
        {
            // Declare a jagged array with 3 rows
            int[][] jagged = new int[3][];

            // Define different lengths for each row
            jagged[0] = new int[2] ;
            jagged[1] = new int[3] ;
            jagged[2] = new int[] { 6 };

            Console.WriteLine("Jagged Array Elements:");

            for (int i = 0; i < jagged.Length; i++)
            {
                Console.Write("Row " + i + ": ");
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j] + " ");
                }
                Console.WriteLine();
            }

            // Required Lab Info
            Console.WriteLine("\nLab No.: 3");
            Console.WriteLine("Name: Alisha Khatri");
            Console.WriteLine("Roll No.:03");
        }
    }
}
