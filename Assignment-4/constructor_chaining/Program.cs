using System;

namespace constructor_chaining
{
    class Student
    {
        public int sid;
        public Student(int id)
        {
            sid=id;
            Console.WriteLine("Hey I'm inside base class");
            Console.WriteLine("I'm also in base class");
        }
    }
    class Example:Student
    {
        public Example(int id):base (id)
        {
            Console.WriteLine("Hey I'm inside derived class");
            Console.WriteLine(id);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           Example obj=new Example(102);

        }
    }
}
