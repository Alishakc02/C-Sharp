//1.  Write a C# program to demonstrate five types of constructor in C#.
using System;

namespace AlishaNCCLab
{
    class Student
    {
        public string name;
        public int age;
        public static string college;

        // 1. Default Constructor
        public Student()
        {
            name = "Alisha";
            age = 21;
            Console.WriteLine("Default Constructor Called");
        }

        // 2. Parameterized Constructor
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine("Parameterized Constructor Called");
        }

        // 3. Copy Constructor
        public Student(Student s)
        {
            this.name = s.name;
            this.age = s.age;
            Console.WriteLine("Copy Constructor Called");
        }

        // 4. Static Constructor
        static Student()
        {
            college = "Nagarjuna College";
            Console.WriteLine("Static Constructor Called");
        }

        // 5. Private Constructor
        private Student(string msg)
        {
            Console.WriteLine("Private Constructor Called: " + msg);
        }

        public void Display()
        {
            Console.WriteLine($"Name: {name}\nAge: {age}\nCollege: {college}\n");
        }

        // Static method to demonstrate Private Constructor
        public static Student CreateWithPrivate()
        {
            return new Student("Created using private constructor inside class");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("--- Demonstrating Constructors ---");

            Student s1 = new Student(); // Default
            s1.Display();

            Student s2 = new Student("Alisha", 21); // Parameterized
            s2.Display();

            Student s3 = new Student(s2); // Copy
            s3.Display();

            Student s4 = Student.CreateWithPrivate(); // Private constructor
            s4.Display();

            // Required Lab Info
            Console.WriteLine("\nLab No.: 1");
            Console.WriteLine("Name: Alisha Khatri");
            Console.WriteLine("Roll No.: 03/NCC");
        }
    }
}
