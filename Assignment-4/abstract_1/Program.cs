using System;

namespace abstract_1
{
    abstract class absproject
    {
        public void Add(int x, int y)
        {
            Console.WriteLine("Addition of numbers is " + (x + y));
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine("Substraction of numbers is " + (x - y));
        }
        public abstract void mul(int x, int y);
        public abstract void div(int x, int y);
    }
    class abschild : absproject
    {
        public override void mul(int i, int j)
        {
            Console.WriteLine("Multiplication of numbers is "+(i * j));
        }
        public override void div(int i, int j)
        {
            Console.WriteLine("Division of numbers is "+ (i / j));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var obj =new abschild();
            obj.Add(10,20);
            obj.mul(10,20);
            obj.Sub(20,10);
            obj.div(20,5);
        }
    }
}
