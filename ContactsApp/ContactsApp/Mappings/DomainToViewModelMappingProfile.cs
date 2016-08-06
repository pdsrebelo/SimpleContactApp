using AutoMapper;
using ContactsApp.Models;

namespace ContactsApp.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            CreateMap<Contacts.Model.Contact, ContactViewModel>();
        }
    }
}
