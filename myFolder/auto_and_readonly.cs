using System;

namespace AlishaNCCLab
{
    class Student
    {
        // Auto Property
        public string Name { get; set; }

        // Read-Only Property
        public int ID { get; }

        // Constructor to initialize Read-Only Property
        public Student(int id, string name)
        {
            ID = id;        // Read-only property can be assigned here
            Name = name;    // Auto property
        }

        public void Display()
        {
            Console.WriteLine($"Student ID: {ID}");
            Console.WriteLine($"Student Name: {Name}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(101, "Alisha Khatri");
            s1.Display();

            // Changing Auto Property
            s1.Name = "Alisha K.";
            Console.WriteLine("\nAfter updating auto property:");
            s1.Display();

            // The following line will give an error if uncommented, because ID is read-only
            // s1.ID = 202; 

            // Required Lab Info
            Console.WriteLine("\nLab No.: 2");
            Console.WriteLine("Name: Alisha Khatri");
            Console.WriteLine("Roll No.: 03");
        }
    }
}
