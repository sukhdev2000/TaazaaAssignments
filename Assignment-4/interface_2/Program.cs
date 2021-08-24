using System;

namespace interface_2
{
    interface Istudent
    {
        public void branch();
    }
    class college:Istudent
    {
        public void branch()
        {
            Console.WriteLine("I'm from computer science branch");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           var obj=new college();
           obj.branch();
        }
    }
}
