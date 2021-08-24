using System;
using collection_demo.Model;
using collection_demo.Proper_Model;
using System.Collections;

namespace collection_demo//camel case
{
    class Program//pascal case
    {
        static void Main()
        {
            var obj=new CountryDetails();//pascal case
            ArrayList arrayList=obj.countryDetails1();//pascal case
             int count=arrayList.Count;
             for(int i=0;i<count;i++)
           {
               System.Console.WriteLine(arrayList[i]);
           }
            var objlist =new CountryDetails();
           var list=objlist.CountryDetails2(); 
           int count1=list.Count;
           for(int i=0;i<count1;i++)
           {
               Console.WriteLine(list[i].currency+" "+list[i].cname);
           }
        }
    }
}
