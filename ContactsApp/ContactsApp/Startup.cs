using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContactsApp.Startup))]
namespace ContactsApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
