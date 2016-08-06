using System.Data.Entity.ModelConfiguration;

namespace Contact.Data.Configurations
{
    public class ContactConfiguration : EntityTypeConfiguration<Contacts.Model.Contact>
    {
        public ContactConfiguration()
        {
            ToTable("Contacts");
            Property(c => c.Name).IsRequired().HasMaxLength(50);
        }
    }
}
