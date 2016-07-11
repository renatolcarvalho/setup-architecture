using System.Reflection;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using SetupWebApplication.Repositories.Interfaces;
using SetupWebApplication.Repositories.Repositories;
using SetupWebApplication.Repositories.Services;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;

namespace SetupWebApplication
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Dependencies
            DependenciesInjection();
        }

        private void DependenciesInjection()
        {
            using (var container = new Container())
            {
                container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
                RegisterDependencies(container);
                container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
                container.Verify();
                DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
            }
        }

        private void RegisterDependencies(Container container)
        {
            container.Register<IUsuarioService, UsuarioService>(Lifestyle.Transient);
            container.Register<IUsuarioRepository, UsuarioRepository>(Lifestyle.Transient);
        }
    }
}