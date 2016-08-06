using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using Contact.Service;
using ContactsApp.Models;

namespace ContactsApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContactService _contactService;

        public HomeController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public ActionResult Index()
        {
            IEnumerable<Contacts.Model.Contact> contacts = 
                _contactService.GetContacts().ToList();

            IEnumerable<ContactViewModel> viewModelGadgets 
                = Mapper.Map<IEnumerable<Contacts.Model.Contact>, IEnumerable<ContactViewModel>>(contacts);

            return View(viewModelGadgets);
        }

        public ActionResult AddContact()
        {
            return View();
        }

        public ActionResult EditContact(ContactViewModel contact)
        {
            return View(contact);
        }

        [HttpPost]
        public ActionResult UpdateContact(ContactViewModel updateContact)
        {
            var contact = Mapper.Map<ContactViewModel, Contacts.Model.Contact>(updateContact);

            _contactService.EditContact(contact);

            _contactService.SaveContact();

            return RedirectToAction("Index");
        }


        [HttpPost]
        public ActionResult CreateContact(ContactViewModel newContact)
        {
            if (newContact != null)
            {
                var contact = Mapper.Map<ContactViewModel, Contacts.Model.Contact>(newContact);
                _contactService.AddContact(contact);

                _contactService.SaveContact();
            }

            return RedirectToAction("Index");
        }

        public ActionResult DeleteContact(ContactViewModel deleteContact)
        {
            var contact = Mapper.Map<ContactViewModel, Contacts.Model.Contact>(deleteContact);

            _contactService.DeleteContact(contact);

            _contactService.SaveContact();

            return RedirectToAction("Index");
        }
    }
}