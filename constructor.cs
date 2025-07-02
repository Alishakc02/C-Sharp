using System;
using System.ComponentModel.DataAnnotations;


namespace Alisha03_CSIT_6th
{
    class Box

    {
        public static int count;//Only one copy create 
        //Static variable shared 
        double length, breadth, height;
        public Box() //parameter less constructor
        {
            length = 4.6;
            breadth = 8.4;
            height = 6.7;
            count++;
        }
        public Box(double length, double breadth, double height) //local variables length, breadth
        {
            this.length = length;
            this.breadth = breadth;
            this.height = height;
        }
        public void Display()
        {
            Console.WriteLine("L= " + length + "B= " + breadth + "H= " + height);
        }
        public static void ShowCount()
        {
            Console.WriteLine("Count=" + count);
        }
    }
    public class First
    {
        static void Main(string[] args)
        {
           
            Box b1 = new Box(2.2, 5.6, 9.9);
            Box b2 = new Box();
            Box b3 = new Box();
            b1.Display();
            b2.Display();
            //constructor is used to initialize the values for an object
            b3.Display();
            Box.ShowCount();
            //Main is the entry point
        }
    }
}
