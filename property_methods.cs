using System;

class Student
{
    // Private field
    private string name;
    private int age;

    // Property for Name
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Property for Age
    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0)
                age = value;
            else
                Console.WriteLine("Age cannot be negative.");
        }
    }

    // Method to display student details
    public void DisplayDetails()
    {
        Console.WriteLine("Student Details:");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }

    // Method to check if the student is adult
    public bool IsAdult()
    {
        return Age >= 18;
    }
}

class Program
{
    static void Main()
    {
        // Create object of Student
        Student student1 = new Student();

        // Use properties to set values
        student1.Name = "Alisha";
        student1.Age = 20;

        // Use method to display details
        student1.DisplayDetails();

        // Use method to check adulthood
        if (student1.IsAdult())
            Console.WriteLine("The student is an adult.");
        else
            Console.WriteLine("The student is not an adult.");
    }
}
