using System;

namespace jagged
{
    class Program
    {
        static void Main(string[] args)
        {
            int [][] jarray=new int[2][];
            jarray[0]=new int[3];
            jarray[1]=new int[4];
            jarray[0][0]=10;
            jarray[0][1]=20;
            jarray[0][2]=30;
            jarray[1][0]=40;
            jarray[1][1]=50;
            jarray[1][2]=60;
            jarray[1][3]=70;
            for(int i=0;i<jarray.GetLength(0);i++)
            {
                Console.Write("\n");
                for(int j=0;j<jarray[i].GetLength(0);j++)
                {
                    System.Console.Write("{0} ",jarray[i][j]);
                }
            }
            Console.ReadKey();
        }
    }
}
