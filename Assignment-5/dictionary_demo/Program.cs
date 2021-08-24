/* A dictionary is a collection of (key,value)pairs and it is present in (system.collection.Genericnamespace), 
here we need to specify types of key and value. */
using System;
using System.Collections.Generic;

namespace dictionary_demo
{
    public class Employee
    {
        public string Ename { get; set; }
        public int Eid { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee()
            {
                Eid = 100,
                Ename = "Sukhdev"
            };
            Employee e2 = new Employee()
            {
                Eid = 101,
                Ename = "Sumit"
            };
            Employee e3 = new Employee()
            {
                Eid = 102,
                Ename = "Kishan"
            };
            Dictionary<int,Employee> Employeesdictionary=new Dictionary<int, Employee>();
            Employeesdictionary.Add(e1.Eid,e1);//here key is id and value is Employee
            Employeesdictionary.Add(e2.Eid,e2);
            Employeesdictionary.Add(e3.Eid,e3);
            Employee first= Employeesdictionary[100];
            foreach(KeyValuePair<int,Employee> item in Employeesdictionary)
            {
                System.Console.WriteLine("Key={0}", item.Key);
                Employee employee=item.Value;
                
                System.Console.WriteLine("Id={0}, Name={1}, ", employee.Eid,employee.Ename);
            }
        }
    }
}
