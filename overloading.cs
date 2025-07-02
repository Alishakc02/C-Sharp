using System;

public class Calculator
{
  
     //Overloading
     //Same name but different parameters
     //Compile time polymorphism
     public int Add(int a, int b)
     {
         return a+b;
     }
     public double Add(double a, double b)
     {
         return a+b;
     }
     
     public int Add(int a, int b, int c)
     {
         return a+b+c;
     }
      public static void Main(string[] args)
    {
    Calculator calc=new Calculator();
    Console.WriteLine(calc.Add(5,3));
    Console.WriteLine(calc.Add(5.9f,3.9f));
    Console.WriteLine(calc.Add(5,3,7));
    } 
    
}
