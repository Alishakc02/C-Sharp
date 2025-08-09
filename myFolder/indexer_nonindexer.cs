using System;

namespace AlishaNCCLab
{
    // a) Indexer when index is of int type
    class IntIndexerDemo
    {
        private string[] names = new string[5];

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < names.Length)
                    return names[index];
                else
                    return "Invalid Index";
            }
            set
            {
                if (index >= 0 && index < names.Length)
                    names[index] = value;
            }
        }
    }

    // b) Indexer when index is of other than int type (string)
    class StringIndexerDemo
    {
        private System.Collections.Generic.Dictionary<string, string> phoneBook =
            new System.Collections.Generic.Dictionary<string, string>();

        public string this[string name]
        {
            get
            {
                if (phoneBook.ContainsKey(name))
                    return phoneBook[name];
                else
                    return "Name not found";
            }
            set
            {
                phoneBook[name] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Indexer with int index ---");
            IntIndexerDemo obj1 = new IntIndexerDemo();
            obj1[0] = "Alisha";
            obj1[1] = "NCC";
            Console.WriteLine(obj1[0]);
            Console.WriteLine(obj1[1]);
            Console.WriteLine(obj1[4]); // empty as not set

            Console.WriteLine("\n--- Indexer with string index ---");
            StringIndexerDemo obj2 = new StringIndexerDemo();
            obj2["Alisha"] = "9812345678";
            obj2["NCC"] = "015555555";
            Console.WriteLine("Alisha's Number: " + obj2["Alisha"]);
            Console.WriteLine("NCC's Number: " + obj2["NCC"]);
            Console.WriteLine("Unknown: " + obj2["XYZ"]);

            // Required Lab Info
            Console.WriteLine("\nLab No.: 4");
            Console.WriteLine("Name: Alisha Khatri");
            Console.WriteLine("Roll No.: 03");
        }
    }
}
