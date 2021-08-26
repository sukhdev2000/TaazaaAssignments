using System;
using day8_O.Adv_Delegate;
//delegate string NameDelegate(string str);
//delegate void PhoneDelegate();
//delegate bool studyStatusDelegate();
namespace day8_O
{
    class Program
    {
        static void Main()
        {
            Study study=new Study();
            /* NameDelegate nameDelegate=new NameDelegate(study.Name);
            string name=nameDelegate.Invoke("Sukhdev");
            System.Console.WriteLine(name);*/

            //funtion delegate 
            Func<string,string> func=study.Name;
            string name=func("Sukhdev");
            Console.WriteLine(name);

            //action delegate
            Action action=study.PNumber;  //we will angular bracket when we have parameters
            //action.Invoke(); first way
            action();  //second way


            //predicate delegate
            Predicate<string> predicate=study.studyStatus;
            bool b=predicate("sukhdev");
            System.Console.WriteLine(b);
        }
    }
}
