using System;

namespace boxing_unboxing
{
    class Program
    {
        //process of converting value type to reference type is called boxing
        //process of converting reference type to value type is called unboxing
        static void Main(string[] args)
        {
        int i=100;
        object obj=i;//boxing
        int x=(int)obj;//unboxing 
        System.Console.WriteLine(i);
        System.Console.WriteLine(obj);
        System.Console.WriteLine(x);
        }
    }
}
