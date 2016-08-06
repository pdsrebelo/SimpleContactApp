namespace Contact.Data.Repositories
{
    public class ContactRepository : RepositoryBase<Contacts.Model.Contact>, IContactRepository
    {
        public ContactRepository(IDbFactory dbFactory)
                : base(dbFactory) { }
    }

    public interface IContactRepository : IRepository<Contacts.Model.Contact>
    {

    }
}
