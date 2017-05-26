namespace App.Business.Interfaces.Repositories
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
