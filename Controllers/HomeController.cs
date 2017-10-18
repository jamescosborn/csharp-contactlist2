using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AddressBook.Models;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
          return View();
        }

        [HttpGet("/ContactList")]
        public ActionResult ContactList()
        {
          List<Contact> allContacts = Contact.GetAll();
          return View(allContacts);
        }

        [HttpGet("/contact/create")]
        public ActionResult ContactForm()
        {
          return View();
          // string newName = Request.Form["new-name"];
          // string newPhoneNumber = Request.Form["new-phone-number"];
          // string newAddress = Request.Form["new-address"];
          // Contact newContact = new Contact (newName, newPhoneNumber, newAddress);
          // newContact.Save();
          // return View(newContact);
        }

        [HttpPost("/contact/created")]
        public ActionResult ContactCreated()
        {
          string name = Request.Form["new-name"];
          string phone = Request.Form["new-phone-number"];
          string address = Request.Form["new-address"];
          Contact newContact = new Contact(name, phone, address);
          List<Contact> allContacts = Contact.GetAll();
          return View(newContact);
        }

        [HttpPost("/contact/list/clear")]
        public ActionResult ContactListClear()
        {
          Contact.ClearAll();
          return View();
        }
        [HttpGet("/ContactList/{id}")]
        public ActionResult ContactDetail(int id)
        {
          Contact contact = Contact.Find(id);
          return View(contact);
        }
    }
}
