using System;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string str="We Are Learning dotnet!!";
            System.Console.WriteLine(str.ToUpper());
            System.Console.WriteLine(str.ToLower());
            System.Console.WriteLine(str.IndexOf("Learning"));
            System.Console.WriteLine(str.Replace("dotnet","C#"));
            System.Console.WriteLine(str.Trim());
            System.Console.WriteLine(str.Insert(16,"Java and "));
            string number="2000";
            int num=int.Parse(number); //throw an exception if null or empty
            System.Console.WriteLine("Number you have entered is "+ num);
        }
    }
}
