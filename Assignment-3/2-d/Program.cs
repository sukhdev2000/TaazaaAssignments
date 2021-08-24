using System;

namespace _2_d
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] twodim={
                {1,2},
                {3,4},
                {5,6}
            };
           System.Console.WriteLine(twodim[0,1]);
           System.Console.WriteLine(twodim[1,1]);

        }
    }
}
