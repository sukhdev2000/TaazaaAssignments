using ContactRepo.Repository;
using ContactRepo.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ContactRepo.Controllers
{
   [ApiController]
    [Route("[controller]")]
    public class ContactsController : ControllerBase
    {
        IContactRepository contactRepository;
        public ContactsController(IContactRepository contactsRepository1)
        {
            contactRepository=contactsRepository1;
        }
        [HttpPost]
        public IActionResult createContact(Contacts contacts)
        {
            contactRepository.Add(contacts);
            return Ok("Record Added");
        }
        [HttpPut]
        public IActionResult updateContact(Contacts contacts)
        {
            contactRepository.Update(contacts);
            return Ok("Updated Successfully");
        }
        [HttpDelete("{EmpId}")]
        public IActionResult RemoveContact(int empId)
        {
            int temp=contactRepository.Remove(empId);
            if(temp==1)
            {
            return Ok("Deleted Succesfully");
            }
            else{
                return Ok("No record Found!!");
            }
        }
        [HttpGet("{EmpId:int}")]
        public IActionResult SearchContact(int empid)
        {
            var i=contactRepository.Find(empid);
            return Ok(i);
        }
        [HttpGet("ContactList")]
        public IActionResult displayContact()
        {
            var temp=contactRepository.GetAll();
            return Ok(temp);
        }
    }
}