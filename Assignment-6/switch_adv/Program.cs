using System;
using System.Collections.Generic;
namespace SwitchCaseProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List< string>();
            int ch=0;
            while(ch>=0 && ch<5)
            {
              Console.WriteLine(" 1.) Add Student\n 2.) Update\n 3.) Search\n 4.) Delete\n 5.) Exit");
               ch = Convert.ToInt32(Console.ReadLine());
              switch(ch)
              {
                  case 1:
                          Console.WriteLine("Enter Student name");
                          string Sname = Console.ReadLine();
                          list.Add(Sname);
                          Console.WriteLine("New student Added!");
                          break;
                 case 2:
                          Console.WriteLine("Enter Student name to update");
                           string Name = Console.ReadLine();
                           if(list.Contains(Name))
                           {
                            Console.WriteLine("Enter Your Updated Name");
                            Sname = Console.ReadLine();
                            int index=list.IndexOf(Name);
                            list[index]=Sname;
                            Console.WriteLine("Student Name Updated!");
                            break;
                           }
                           else
                           {
                             Console.WriteLine("Student Does not exists");
                             break;
                           }
                  case 3:
                          Console.WriteLine("Enter Student name for Search");
                           Sname = (Console.ReadLine());
                           if(list.Contains(Sname))
                           {
                            Console.WriteLine("Student Found!");
                            break;
                           }
                           else
                           {
                             Console.WriteLine("Student Does not exists");
                             break;
                           } 
                    case 4:
                           Console.WriteLine("Enter Student Name which you want to Delete");
                           Sname=(Console.ReadLine());
                           if(list.Contains(Sname))
                           {
                            list.Remove(Sname);
                            Console.WriteLine("Student Deleted!");
                            break;
                           }
                           else
                           {
                             Console.WriteLine("tudent Does not exists");
                             break;
                           }  
              }
            }
        }
    }
}

