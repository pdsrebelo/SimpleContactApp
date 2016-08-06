using System.Collections.Generic;
using Contact.Data;
using Contact.Data.Repositories;

namespace Contact.Service
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ContactService(IContactRepository contactRepository, IUnitOfWork unitOfWork)
        {
            _contactRepository = contactRepository;
            _unitOfWork = unitOfWork;
        }

        public void AddContact(Contacts.Model.Contact contact)
        {
            _contactRepository.Add(contact);
        }

        public void SaveContact()
        {
            _unitOfWork.Commit();
        }

        public IEnumerable<Contacts.Model.Contact> GetContacts()
        {
            return _contactRepository.GetAll();
        }

        public void EditContact(Contacts.Model.Contact contact)
        {
            _contactRepository.Update(contact);
        }

        public void DeleteContact(Contacts.Model.Contact contact)
        {
            _contactRepository.Delete(contact);
        }
    }
}
