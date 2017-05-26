using App.Business.Interfaces.Repositories;
using App.Business.Interfaces.Services;
using App.Business.Services;
using App.Data.Context;
using App.Data.Repositories;
using SimpleInjector;

namespace BootStrapper
{
    public class SimpleInjectorMapping
    {
        // Lifestyle.Transient => Uma instancia para cada solicitacao;
        // Lifestyle.Singleton => Uma instancia unica para a classe
        // Lifestyle.Scoped => Uma instancia unica para o request
        public static void Register(Container container)
        {
            //Business
            container.Register<IExampleService, ExampleService>(Lifestyle.Scoped);
            container.Register<IManagerLog, ManagerLog>(Lifestyle.Scoped);

            //Data
            container.Register<IExampleRepository, ExampleRepository>(Lifestyle.Scoped);
            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
            container.Register<MainContext>(Lifestyle.Scoped);
        }
    }
}
