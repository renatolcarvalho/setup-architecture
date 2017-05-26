using App.Business.Interfaces.Repositories;
using App.Business.Interfaces.Services;
using App.Business.Model;
using App.Business.ViewModel;

namespace App.Business.Services
{
    public class ExampleService : ServiceBase<Example, ExampleViewModel>, IExampleService
    {
        private readonly IExampleRepository _exampleRepository;
        public ExampleService(IExampleRepository exampleRepository, IUnitOfWork uow) : base(exampleRepository, uow)
        {
            _exampleRepository = exampleRepository;
        }
    }
}