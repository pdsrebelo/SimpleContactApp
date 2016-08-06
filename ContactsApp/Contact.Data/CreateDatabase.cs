using System.Collections.Generic;
using System.Data.Entity;

namespace Contact.Data
{
    public class CreateDatabase : DropCreateDatabaseIfModelChanges<StoreEntities>
    {
        protected override void Seed(StoreEntities context)
        {
            GetContacts().ForEach(c => context.Contacts.Add(c));

            context.Commit();
        }

        private static List<Contacts.Model.Contact> GetContacts()
        {
            return new List<Contacts.Model.Contact>
            {
                new Contacts.Model.Contact
                {
                    ContactID = 1,
                    Name = "A Name",
                    Surname = "A Surname",
                    Address = "A Address",
                    Age = 1
                },
                new Contacts.Model.Contact
                {
                    ContactID = 2,
                    Name = "B Name",
                    Surname = "B Surname",
                    Address = "B Address",
                    Age = 2
                },
                new Contacts.Model.Contact
                {
                    ContactID = 3,
                    Name = "C Name",
                    Surname = "C Surname",
                    Address = "C Address",
                    Age = 3
                },
                new Contacts.Model.Contact
                {
                    ContactID = 4,
                    Name = "D Name",
                    Surname = "D Surname",
                    Address = "D Address",
                    Age = 4
                },
                 new Contacts.Model.Contact
                {
                    ContactID = 5,
                    Name = "E Name",
                    Surname = "E Surname",
                    Address = "E Address",
                    Age = 5
                }
            };
        }
    }
}
