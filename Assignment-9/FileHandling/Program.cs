using System;
using FileHandling.Files;
namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            FileHandler filehandler=new FileHandler();
            filehandler.WriteToFile("I am Sukhdev");
            filehandler.ReadFromFile();
        }
    }
}
    
