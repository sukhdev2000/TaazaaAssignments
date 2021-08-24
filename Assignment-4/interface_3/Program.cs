using System;

namespace interface_3
{
    interface Icustomer
    {
        public void print1();
    }
    interface Ishopkeeper
    {
        public void print2();
    }
    public class test:Icustomer
    {
        public void print1()
        {
            System.Console.WriteLine("Hey I'm defining the funtion inside I customer interface");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var obj=new test();
            obj.print1();
        }
    }
}
