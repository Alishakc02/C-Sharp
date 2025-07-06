using System;
using System.Linq;  

class LINQDemo
{
    static void Main(string[] args)
    {
        int[] scores = new int[] { 45, 67, 86 };
        var result1 = from scr in scores where scr > 60 select scr;
        Console.WriteLine("Name: Alisha Khatri");
        Console.WriteLine("Roll no: 03");
        
        Console.WriteLine("Scores greater than 60 are:");
        foreach (int i in result1)
        {
            Console.Write(i + " ");
        }
        //LINQ2
        var result2 = from scr in scores where scr>60 orderby scr descending select scr;
        Console.WriteLine("\nScores greater than 60 in descending order are:");
          foreach (int i in result2)
        {
            Console.Write(i + " ");
        }
              
    }
}
