using App.Data.Context;
namespace App.Data.Repositories
{
    public class ExampleRepository : RepositoryBase<Business.Model.Example>, Business.Interfaces.Repositories.IExampleRepository
    {
        public ExampleRepository(MainContext mainContext) : base(mainContext) { }
    }
}