using System.Collections.Generic;

namespace Contact.Service
{
    public interface IContactService
    {
        void AddContact(Contacts.Model.Contact contact);

        IEnumerable<Contacts.Model.Contact> GetContacts();

        void EditContact(Contacts.Model.Contact contact);

        void DeleteContact(Contacts.Model.Contact contact);

        void SaveContact();
    }
}
