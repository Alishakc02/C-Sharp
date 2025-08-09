using System;

namespace AlishaNCCLab
{
    // Base class
    class Person
    {
        public string name;

        // Base class constructor
        public Person(string name)
        {
            this.name = name;
            Console.WriteLine("Base class constructor called.");
        }

        // Base class method
        public void ShowDetails()
        {
            Console.WriteLine("Name (from base class): " + name);
        }
    }

    // Derived class
    class Student : Person
    {
        public string college;

        // Using base keyword to call base class constructor
        public Student(string name, string college) : base(name)
        {
            this.college = college;
            Console.WriteLine("Derived class constructor called.");
        }

        // Method demonstrating base keyword to access base class field and method
        public void Display()
        {
            Console.WriteLine("Accessing base class field using base keyword: " + base.name);
            base.ShowDetails(); // Calling base class method
            Console.WriteLine("College (from derived class): " + college);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Alisha Khatri", "Nagarjuna College");
            s.Display();

            // Required Lab Info
            Console.WriteLine("\nLab No.: 5");
            Console.WriteLine("Name: Alisha Khatri");
            Console.WriteLine("Roll No.: 03");
        }
    }
}
