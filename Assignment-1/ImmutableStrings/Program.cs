using System;
//String objects are always immutable, once they created and initialized then cannot be changed on same reference
namespace ImmutableStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str="Old Value";
            str="new Value";
            System.Console.WriteLine("String is "+ str);
            string str1="My Name is Das sukhdev";
            string str2="My Name is Das sukhdev";
            string str3="My Name is"+" "+"Das sukhdev";
            string str4=new string("My Name is Das sukhdev");
            System.Console.WriteLine(str4);
        }
    }
}
