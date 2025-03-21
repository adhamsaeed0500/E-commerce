namespace E_commerce_System.Layer.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        IProducRepository Product { get; }

        void Save();
    }
}
