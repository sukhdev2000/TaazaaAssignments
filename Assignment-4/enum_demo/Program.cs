using System;
namespace enum_demo
{
    public enum days   //enum is user defined data type
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }
    class test
    {
        static void Main()
        {
            for(int i=0;i<=4;i++)
            {
                days d=(days)i;
                Console.WriteLine(d);
            } 
        }

    }
}