using System;

// Define the custom attribute with necessary properties.
[AttributeUsage(AttributeTargets.All)]
public class MyAttribute : Attribute 
{
    public string Name { get; }
    public string Action { get; }

    public MyAttribute(string name, string action)
    {
        Name = name;
        Action = action;
    }
}

class Student 
{
    private int rollNo;
    private string stuName;
    private double marks;

    [MyAttribute("Modifier", "Assigns the Student Details")]
    public void SetDetails(int r, string sn, double m)
    {
        rollNo = r;
        stuName = sn;
        marks = m;
    }

    [MyAttribute("Accessor", "Returns the roll number")]
    public int GetRollNo() => rollNo;

    [MyAttribute("Accessor", "Returns the student name")]
    public string GetStuName() => stuName;

    [MyAttribute("Accessor", "Returns the marks")]
    public double GetMarks() => marks;
}

class TestAttributes 
{
    static void Main()
    {
        Student s = new Student();
        s.SetDetails(1, "Taylor", 92.5);

        Console.WriteLine("Student Details:");
        Console.WriteLine("Roll Number: " + s.GetRollNo());
        Console.WriteLine("Name: " + s.GetStuName());
        Console.WriteLine("Marks: " + s.GetMarks());
    }
}
