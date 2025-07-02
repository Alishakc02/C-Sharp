using System;
using System.Net.NetworkInformation;

namespace Alisha03_CSIT_6th
{
    class Calculator<T>

    {

        // public void sum(double a, double b)
        //{
        //    Console.WriteLine(a+b);
        //}
        //public void sum(float a, float b)
        //{
        //    Console.WriteLine(a+b);
        //}
        public void sum(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            Console.WriteLine(x + y);

        }
        public void diff(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            Console.WriteLine(x - y);

        }
        public void mul(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            Console.WriteLine(x * y);

        }
    }
    internal class GenericTest
{
        static void Main(string[] args)
        {
            Calculator<int> gt = new Calculator<int>();
            gt.sum(1, 2);
            gt.diff(1, 2);
            gt.mul(1, 2);
            Calculator<float> gt1 = new Calculator<float>();
            gt1.sum(5.6f, 2.3f);
            gt1.diff(5.6f, 2.3f);
            gt1.mul(5.6f, 2.4f);

        }

    }
}
   
