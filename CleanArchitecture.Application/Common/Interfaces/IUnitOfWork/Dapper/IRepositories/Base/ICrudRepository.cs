using System.Linq.Expressions;
using CleanArchitecture.Domain.Entities.Base;

namespace CleanArchitecture.Application.Common.Interfaces.IUnitOfWork.Dapper.IRepositories.Base
{
    public interface ICrudRepository<TEntity, TKey> where TEntity : IEntity
    {
        #region Read

        //*********************************************************************************    Read

        TEntity Get(TKey id);
        Task<TEntity> GetAsync(TKey id);
        TEntity Single(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> SingleAsync(Expression<Func<TEntity, bool>> predicate);
        TEntity FirstOrDefault(TKey id);
        Task<TEntity> FirstOrDefaultAsync(TKey id);
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
        TEntity Load(TKey id);
        List<TEntity> GetAllList();
        Task<List<TEntity>> GetAllListAsync();
        List<TEntity> GetAllList(Expression<Func<TEntity, bool>> predicate);
        Task<List<TEntity>> GetAllListAsync(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] propertySelectors);

        #endregion

        #region Create

        //*********************************************************************************    Create

        TEntity Insert(TEntity entity);
        Task<TEntity> InsertAsync(TEntity entity);

        void BulkInsert(IEnumerable<TEntity> entities);
        Task BulkInsertAsync(IEnumerable<TEntity> entities);

        TKey InsertAndGetId(TEntity entity);
        Task<TKey> InsertAndGetIdAsync(TEntity entity);

        #endregion

        #region Create or Update

        //*********************************************************************************    Create or Update

        TEntity InsertOrUpdate(TEntity entity);
        Task<TEntity> InsertOrUpdateAsync(TEntity entity);
        TKey InsertOrUpdateAndGetId(TEntity entity);
        Task<TKey> InsertOrUpdateAndGetIdAsync(TEntity entity);

        #endregion

        #region Update

        //*********************************************************************************    Update

        bool Update(TEntity entity);
        Task<bool> UpdateAsync(TEntity entity);


        #endregion

        #region Delete

        //*********************************************************************************    Delete

        bool Delete(TEntity entity);
        Task<bool> DeleteAsync(TEntity entity);
        bool Delete(TKey id);
        Task<bool> DeleteAsync(TKey id);
        int Delete(Expression<Func<TEntity, bool>> predicate);
        Task<int> DeleteAsync(Expression<Func<TEntity, bool>> predicate);

        #endregion
    }

    public interface ICrudRepository<TEntity> : ICrudRepository<TEntity, int> where TEntity : IEntity
    {
    }    
}