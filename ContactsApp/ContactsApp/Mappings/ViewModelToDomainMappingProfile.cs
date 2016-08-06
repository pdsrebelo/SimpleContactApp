using AutoMapper;
using ContactsApp.Models;

namespace ContactsApp.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            CreateMap<ContactViewModel, Contacts.Model.Contact>();
        }
    }
}
