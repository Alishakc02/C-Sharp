using System;


namespace Alisha03_CSIT_6th
{
    class Student
    {
        int id;
        string name;
        float marks;
        string address;
        public Student(int id, string name, float marks, string address)
        {
            this.id = id;
            this.name = name;
            this.marks = marks;
            this.address = address;
        }
        //Indexer
        public object this[int index]
        {
            get
            {
                if (id == 0)
                {
                    return id;
                }
               else if (id == 1)
                {
                    return name;
                }
                else if(id==3)
                {
                    return marks;
                }
                else if(id == 4)
                {
                    return address;
                }
                else
                {
                    return null;
                }
        }
            set
            {
                if(index==0)
                {
                    this.id = (int).value;
                }
            }

    }
    internal class Indexer
    {
        static void Main(string[] args)
        {
            Student s = new Student(102,"Ram", 3.5f, "Bkt");
                s[0]=207;
            Console.WriteLine($"Name={s[1]}");
            Console.WriteLine($"Id={s[0]}");
        }
    }
}
