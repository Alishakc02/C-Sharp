using System;


namespace Alisha03_CSIT_6th
{
    class Circle
    {
        private double radius;
        public double Radius
            {
            get 
            { 
                return this.radius;//IF ONLY GET IS AVIALBLE, THEN READ ONLY PROPERTY
            }
            set
            {
                this.radius = value;//IF ONLY SET IS AVIALBLE, THEN WRITE ONLY PROPERTY
            }
            ////IF BOTH ARE AVAILABLE, THEN IT IS CALLED READ AND WRITE PROPERTY
        }
        //public double GetRadius()
        //  {
        //  return this.radius;

        //  }
        // public void SetRadius(double radius)
        // {
        // this.radius=radius;
        // }
    }
    internal class Property
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.Radius=12.7;
            Console.WriteLine($"Radius={c.Radius}");

        }
    }
}

