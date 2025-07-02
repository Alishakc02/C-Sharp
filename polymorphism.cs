
using System;
using System.Security.Cryptography.X509Certificates;


namespace Alisha03_CSIT_6th
{
    class Figure
    {
        protected double dim1, dim2;
        public Figure(double a , double b)
        {
            dim1 = a;
            dim2 = b;
        }
        public  virtual double Area()
        {
            Console.WriteLine("\t Area for the figure is undefined.”);
             return 0;

        }

    }
    class Rectangle : Figure
    {
        public Rectangle(double a, double b):base(a,b)
        {

        }
        //Overriding area for rectangle
        public override double Area()
        {
            Console.WriteLine("\t Inside area for rectangle.");
            return dim1 * dim2;
        }
        }
    class Triangle: Figure
    {

        public Triangle(double a, double b) : base(a, b)
        {
        }
            //OVERRIDING AREA FOR RIGHT ANGLED TRIANGLE
            public override double Area()
        {
            Console.WriteLine("\t Inside area for right angled triangle.");
            return (dim1 * dim2) / 2;

        }
        
    }
    class FindAreas
    {
        static void Main(string[] args)
        {
            Figure f = new Figure(10.5, 6.7);
            Rectangle r = new Rectangle(8.9, 5.6);
            Triangle t = new Triangle(5.6, 7.8);
            Figure figref;
            figref = r;
            Console.WriteLine("\t Area is" + figref.Area());
            figref = t;
            Console.WriteLine("\t Area is" + figref.Area());
            figref = f;
            Console.WriteLine("\t Area is" + figref.Area());




        }
    }
 internal class Polyorphism_dynamic
    {

    }
}
//Dynamic polymorphism-runtime binding, runtime polymorphism, 



