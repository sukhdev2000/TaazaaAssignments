using System;
namespace interfaceconcept
{
    interface Ifirst
    {
        void fun1();
    }
    class first:Ifirst
    {
     public void fun1()
      {
          System.Console.WriteLine("Hey I'm from interface1!!");
      }
      
    }
    class Program
    {
        static void Main(string[] args)
        {
          var obj=new first();
          Ifirst obj1=new first();
          obj.fun1();
          obj1.fun1();
        }
    }
}
