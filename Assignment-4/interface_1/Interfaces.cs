using System;

namespace interface_1
{
    interface Ifirst
    {
        void add(int a,int b);
    }
    
    interface Isecond:Ifirst
    {
        void sub(int a,int b);
    }
    class test:Ifirst, Isecond
    {
        public void add(int a,int b)
        {
            Console.WriteLine("Addition of two numbers is "+(a+b));
        }
        
        public void sub(int a,int b)
        {
            Console.WriteLine("substraction of two numbers is "+(a-b));
        }
    }
    class interfaces
    {
        static void Main(string[] args)
        {
            var obj=new test();
            obj.add(10,20);
            obj.sub(70,50);
        }
    }
}
