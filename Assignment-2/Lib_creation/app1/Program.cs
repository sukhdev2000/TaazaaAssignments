using System;
using lab1;
using lab2;
namespace app1
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj1=new library1();
            var obj2=new library2();
            obj1.funcLib1();
            obj2.funcLib2();
        }
    }
}
