/* Hash Table is basically a collection of key-value pairs where key is an indexer and value is accessed by the key and it implementes IDictionary interface*/

using System;
using System.Collections;
namespace hash_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Hashtable hashtable=new Hashtable();
            //Inserting
            hashtable.Add(1,"Computer science");
            hashtable.Add(2,"Mechanical");
            hashtable.Add(3,"Civil");
            hashtable.Add(4,"Electricals");
            //deletion
            hashtable.Remove(4);
            //search by value()
            System.Console.WriteLine(hashtable.ContainsKey(4)); //return true or false based on value
            //search by key
            System.Console.WriteLine(hashtable.ContainsValue("Civil"));
            System.Console.WriteLine("Current value at index 2 is "+hashtable[2]);
            //updation of value by indexes
            hashtable[2]="Aeronautical Engineering";
            System.Console.WriteLine("value after updation at index 2 is "+hashtable[2]);
            //Accessing elements
           foreach (DictionaryEntry item in hashtable)
           {
               System.Console.WriteLine("value of Key "+item.Key+" is "+item.Value);
               
           }
        }
    }
}
