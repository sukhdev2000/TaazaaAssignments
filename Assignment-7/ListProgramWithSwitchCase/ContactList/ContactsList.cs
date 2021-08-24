using System;
using System.Collections.Generic;
using ListProgramWithSwitchCase.Model;
namespace ListProgramWithSwitchCase.ContactList
{
    public class ContactsList
    {
        List<Contact> objList;
        public ContactsList()
        {
            objList=new List<Contact>();
        }
        public int createContact(Contact objContact)
        {
            objList.Add(objContact);
            return 1;
        }
        public List<Contact> DisplayList()
        {
            return objList;
        }
        public void deleteContact(int index)
        {
            objList.RemoveAt(index);
        }
        public void updateContact(int index)
        {
            System.Console.WriteLine("Enter the name you want to Update");
            string Name=Console.ReadLine();
            objList[index].Name=Name;
        }
        public Contact Search(int index)
        {
            return objList.Find(e=>e.Id==index);
        }
        
    }
}