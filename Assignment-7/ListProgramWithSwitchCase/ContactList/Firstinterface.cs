using ListProgramWithSwitchCase.Model;
using ListProgramWithSwitchCase.ContactList;
using System.Collections.Generic;
namespace ListProgramWithSwitchCase.ContactList

{
    public interface Firstinterface
    {
        int createContact(Contact objContact);
         List<Contact> DisplayList();
         void deleteContact(int index);
         void updateContact(int index);
         Contact Search(int index);     
    }
}