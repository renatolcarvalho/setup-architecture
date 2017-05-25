using App.Business.Interfaces.Repositories;
using App.Business.Interfaces.Services;
using App.Business.Model;

namespace App.Business.Services
{
    public class ExampleService : ServiceBase<Example>, IExampleService
    {
        private readonly IExampleRepository _exampleRepository;
        public ExampleService(IExampleRepository exampleRepository) : base(exampleRepository)
        {
            _exampleRepository = exampleRepository;
        }
    }
}