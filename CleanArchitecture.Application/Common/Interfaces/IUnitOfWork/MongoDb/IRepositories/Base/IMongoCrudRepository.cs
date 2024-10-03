namespace CleanArchitecture.Application.Common.Interfaces.IUnitOfWork.MongoDb.IRepositories.Base
{
    public interface IMongoCrudRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        Task<TEntity> GetById(Guid id);
        Task<IEnumerable<TEntity>> GetAll();
        void Update(TEntity obj);
        void Remove(Guid id);
    }
}