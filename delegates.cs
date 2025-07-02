
using System;

namespace Alisha03_CSIT_6th
{
    //Delegate declaration
    public delegate void DemoDelegate(string name);
    

    internal class Delegate
    {
        public void Greet(string name)
        {
            Console.WriteLine($"Hello:{name} namaste!");
        }
        public string Hello(string name)
        {
            return $"Hi!, {name}";
        }
        static void Main(string[] args)
        {
            Delegate dt= new Delegate();
            //Setting the target method to delegate
            DemoDelegate demo = new DemoDelegate(dt.Greet);
            //DemoDelegate dd = dt.Greet;
            demo.Invoke("Hari");
            // or demo("Hari");


        }
    }
}

