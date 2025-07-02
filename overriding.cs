using System;

public class Animal
{
    // 'virtual' keyword allows overriding
    public virtual void speak()
    {
        Console.WriteLine("Animal speaks.");
    }
}

public class Dog : Animal
{
    // 'override' keyword to override the virtual method
    // If we use new keyword instead of override, base class will be completely disappear which isn't the right practice
    public override void speak()
    {
        Console.WriteLine("Dog barks");
    }
}

public class Program
{
    // 'Main' method must be inside a class (usually called Program)
    public static void Main(string[] args)
    {
        Animal a1 = new Dog(); // Polymorphism: base class reference to derived object
        a1.speak();            // Calls Dog's overridden method: "Dog barks"
    }
}
