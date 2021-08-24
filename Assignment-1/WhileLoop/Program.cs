using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,r, sum=0,temp;
            Console.WriteLine("Enter Number!!");
            n=Convert.ToInt32(Console.ReadLine());
            temp=n;
            while(n>0)
            {
                r=n%10;
                sum=sum*10+r;
                n=n/10;
            }
            n=temp;
            if(n==sum)
            {
                Console.WriteLine("Number is Palindrome!!");
            }
            else
            {
                Console.WriteLine("Number is Not a Palindrome!!");
            }
            
        }
    }
}
