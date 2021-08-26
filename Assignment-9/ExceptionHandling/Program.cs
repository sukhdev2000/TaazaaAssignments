using System;
using ExceptionHandling;
namespace ExceptionHandling
{
    class Program
    {
        static void Main()
        {
            Customers customers=new  Customers();
            customers.getData(10,0);   
        }
    }
}
