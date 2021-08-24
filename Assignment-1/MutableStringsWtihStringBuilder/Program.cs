using System;
using System.Text;
namespace MutableStringsWtihStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
         StringBuilder str=new StringBuilder();
          str.Append("Hey ");
          str.Append("My name is sukhdev,");
          str.Append(" Have a great day!!");
          System.Console.WriteLine(str);
        }
    }
}
