using System;

namespace Special_Topic
{
    class Program
    {
         public static int add(params int[] num)
        {
            int sum=0;
            foreach (var i in num)
            {
                sum=sum+i;
            }
            return sum;
        }
        public static void Details(string Name,int i=1)
        {
            Console.WriteLine(Name+" "+i);
        }
        static void Main()
        {
            System.Console.WriteLine(Program.add(10,20));
            Program.Details("Sukhdev");
            Program.Details("Sukhdev",10);
       }
    }
}