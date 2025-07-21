using System;

namespace nsDivZero
{
    public class DivZero
    {
        public static void Main()
        {
            int a = 57, b = 0;
            try
            {
                Console.WriteLine($"{a} / {b} = {a / b}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            double x = 57.3, y = 0.0;
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
    }
}
