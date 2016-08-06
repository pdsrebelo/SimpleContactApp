using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Contact.Data;
using ContactsApp.App_Start;

namespace ContactsApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Init Database
            System.Data.Entity.Database.SetInitializer(new CreateDatabase());

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Autofac and Automapper configurations
            Bootstrapper.Run();
        }
    }
}
