/* when a constructor is created with private keyword in a class, and we cannot create child class of that class neither it is possible to 
create instance of that class. They are used in classes that contain static members only. */

using System;
namespace private_constructor
{
    class Example
    {
        static public int i;
        private Example()
        {}
        public static void getTimeDetails()
        {
            System.Console.WriteLine(DateTime.Now);
        }
        public static int update(int x)
        {
            return ++x;
        }
    }
    /* class Example2:Example
    {
        error
    } */
    class Program
    {
        static void Main(string[] args)
        {
            //var obj=new Example(); error
            Example.getTimeDetails();
            var val=Example.update(20);
            System.Console.WriteLine("Incremented Value of I is "+val);
           
        }
    }
}
