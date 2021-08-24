using System;
using ListProgramWithSwitchCase.Model;
using ListProgramWithSwitchCase.ContactList;
using System.Collections.Generic;
namespace ListProgramWithSwitchCase
{
    class Program
    {
        static void Main()
        {
            int ch = 0;
            ContactsList objContactList = new ContactsList();
            while (ch >= 0 && ch <= 5)
            {
                System.Console.WriteLine("Which action you want to perform??\n");
                System.Console.WriteLine(" 1.) Add\n 2.) Display\n 3.) Update\n 4.) Delete\n 5.) Search\n 6.) Exit");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    //addition
                    case 1:
                        Contact objContact = new Contact();
                        System.Console.WriteLine("Enter the Id");
                        int id = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("Enter the name");
                        string Name = Console.ReadLine();
                        objContact.Id = id;
                        objContact.Name = Name;
                        int temp = objContactList.createContact(objContact);
                        if (temp == 1)
                            System.Console.WriteLine("Added Successfully!!");
                        break;

                    //display
                    case 2:
                        System.Console.WriteLine("Details Are Here!!");
                        List<Contact> objectContact = objContactList.DisplayList();
                        int count = objectContact.Count;
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine(objectContact[i].Id + " " + objectContact[i].Name);
                        }
                        break;

                    //updation
                    case 3:
                        System.Console.WriteLine("Which record you want to update...provide the index?? ");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        objContactList.updateContact(num1);
                        System.Console.WriteLine("updated Successfully!!");
                        break;

                    //deletion
                    case 4:
                        System.Console.WriteLine("Which record you want to delete please provide index !!");
                        int num = Convert.ToInt32(Console.ReadLine());
                        objContactList.deleteContact(num);
                        System.Console.WriteLine("Deleted Successfully!!");
                        break;

                    case 5:
                        System.Console.WriteLine("Enter Id You want to search!!");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        Contact contact = objContactList.Search(num2);
                        Console.WriteLine(contact.Id + " " + contact.Name);
                        break;

                    default:
                        System.Console.WriteLine("Invalid Input!!");
                        break;
                }
            }
            /* Contact objContact = new Contact();
            objContact.Id = 101;
            objContact.Name = "Sukhdev";

            Contact objContact1 = new Contact();
            objContact1.Id = 102;
            objContact1.Name = "Das Sukhdev";

            int temp;
            ContactsList objContactList = new ContactsList();
            temp=objContactList.createContact(objContact);
            temp=objContactList.createContact(objContact1);
            if(temp==1)
            {
                System.Console.WriteLine("Added Successfully!!");
            }
        */
            /*  List<Contact> objectContact = objContactList.DisplayList();
             foreach (var item in objectContact)
             {
                 Console.WriteLine(item.Id + " " + item.Name);
             } */
        }
    }
    
}
