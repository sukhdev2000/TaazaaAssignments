using System;

namespace Forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n ,count=0;
            Console.WriteLine("Enter a Number!!");
            n=Convert.ToInt32(Console.ReadLine());    //return 0 if null or empty
            for(int i=1;i<=n;i++)
            {
                if(n%i==0)
                {
                    count++;
                }
            }
            if(count==2)
            {
                Console.WriteLine("You entered Prime Number!!");
            }
            else
            {
                Console.WriteLine("You entered Non Prime Number!!");
            }
        }
    }
}
