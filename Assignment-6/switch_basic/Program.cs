using System;

namespace switch_basic
{
       public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number and it will show associated case on that number!!");
            int temp = Convert.ToInt32(Console.ReadLine());
            switch (temp)
            {
                case 1:
                    System.Console.WriteLine("First case has been called!!");
                    break;
                case 2:
                    System.Console.WriteLine("Second case has been called!!");
                    break;
                case 3:
                    System.Console.WriteLine("Third case has been called!!");
                    break;
                case 4:
                    System.Console.WriteLine("Fourth case has been called!!");
                    break;
                default:
                    System.Console.WriteLine("No Function");
                    break;
            }
        }
    }
}
