using System;
using DelegatePractice.Arithmetic;
delegate void ArithmeticDelegate(double N1,double N2);
namespace DelegatePractice
{
    class Program
    {
        static void Main(string[] args)
        {
           /*  //first way
            ArithmeticDelegate obj=new ArithmeticDelegate(ArithmeticOperation.Addition);
            obj.Invoke(5,4);
            //Anonymous method(Second Way)
           ArithmeticDelegate obj1=delegate(double d1,double d2)
           {
               Console.WriteLine("Multiply "+(d1*d2));
           };
           ArithmeticDelegate obj2=delegate(double d1,double d2)
           {
               Console.WriteLine("Division "+(d1/d2));
           }; */


           //Lambda method (third way)
           ArithmeticDelegate obj1=(double d1,double d2)=>
           {
               Console.WriteLine("Multiply "+(d1*d2));
           };
           ArithmeticDelegate obj2=(double d1,double d2)=>
           {
               Console.WriteLine("Division "+(d1/d2));
           };
           obj1(10,20);
           obj2(20,5);
        }
    }
}
