using CleanArchitecture.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq.Expressions;
using System.Reflection;

using Dommel;
using System;
using static Dapper.SqlMapper;
using CleanArchitecture.Application.Common.Interfaces.IUnitOfWork.Dapper.IRepositories.Base;

namespace CleanArchitecture.Persistence.Dapper.Repositories.Base
{
    public class CrudRepository<TEntity, TKey> : ICrudRepository<TEntity, TKey> where TEntity : class, IEntity
    {
        protected IDbTransaction Transaction { get; }
        protected IDbConnection Connection => Transaction.Connection;

        protected CrudRepository(IDbTransaction transaction)
        {
            Transaction = transaction;
        }
        public TEntity Get(TKey id)
        {
            var res = Connection.Get<TEntity>(id, Transaction);
            return res;
        }

        public async Task<TEntity> GetAsync(TKey id)
        {
            var res = await Connection.GetAsync<TEntity>(id, Transaction);
            return res;
        }

        public TEntity Single(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// hi mr
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public Task<TEntity> SingleAsync(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity FirstOrDefault(TKey id)
        {
            throw new NotImplementedException();
        }

        public async Task<TEntity> FirstOrDefaultAsync(TKey id)
        {
            throw new NotImplementedException();
        }

        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            var res = Connection.FirstOrDefault(predicate, Transaction);
            return res;
        }

        public async Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            var res = await Connection.FirstOrDefaultAsync(predicate, Transaction);
            return res;
        }

        public TEntity Load(TKey id)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAllList()
        {
            var res = Connection.GetAll<TEntity>(Transaction);
            return res.ToList();
        }
        ///
        public async Task<List<TEntity>> GetAllListAsync()
        {
            var res = await Connection.GetAllAsync<TEntity>(Transaction);
            return res.ToList();

        }

        public List<TEntity> GetAllList(Expression<Func<TEntity, bool>> predicate)
        {
            var res = Connection.Select(predicate, Transaction);
            return res.ToList();
        }

        public async Task<List<TEntity>> GetAllListAsync(Expression<Func<TEntity, bool>> predicate)
        {
            var res = await Connection.SelectAsync(predicate, Transaction);
            return res.ToList();
        }

        public IQueryable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] propertySelectors)
        {
            throw new NotImplementedException();
        }

        public TEntity Insert(TEntity entity)
        {
            var insertedId = Connection.Insert(entity, Transaction);
            return entity;
        }

        public async Task<TEntity> InsertAsync(TEntity entity)
        {
            var insertedId = await Connection.InsertAsync(entity, Transaction);
            return entity;
        }

        public TKey InsertAndGetId(TEntity entity)
        {
            var insertedId = Connection.Insert(entity, Transaction);
            return (TKey)insertedId;
        }

        public async Task<TKey> InsertAndGetIdAsync(TEntity entity)
        {
            var insertedId = await Connection.InsertAsync(entity, Transaction);
            return (TKey)insertedId;
        }

        public void BulkInsert(IEnumerable<TEntity> entities)
        {
            Connection.InsertAll(entities, Transaction);
        }

        public async Task BulkInsertAsync(IEnumerable<TEntity> entities)
        {
            await Connection.InsertAllAsync(entities, Transaction);
        }
        public TEntity InsertOrUpdate(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> InsertOrUpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TKey InsertOrUpdateAndGetId(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TKey> InsertOrUpdateAndGetIdAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(TEntity entity)
        {
            var isUpdated = Connection.Update(entity, Transaction);
            return isUpdated;
        }

        public async Task<bool> UpdateAsync(TEntity entity)
        {
            var isUpdated = await Connection.UpdateAsync(entity, Transaction);
            return isUpdated;
        }

        public bool Delete(TEntity entity)
        {
            var isdeleted = Connection.Delete(entity, Transaction);
            return isdeleted;
        }

        public async Task<bool> DeleteAsync(TEntity entity)
        {
            var isdeleted = await Connection.DeleteAsync(entity, Transaction);
            return isdeleted;
        }

        public bool Delete(TKey id)
        {
            var entityForDelete = Get(id);
            if (entityForDelete != null)
            {
                Connection.Delete(entityForDelete, Transaction);
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteAsync(TKey id)
        {
            var entityForDelete = Get(id);
            if (entityForDelete != null)
            {
                await Connection.DeleteAsync(entityForDelete, Transaction);
                return true;
            }
            return false;
        }

        public int Delete(Expression<Func<TEntity, bool>> predicate)
        {
            return Connection.DeleteMultiple(predicate, Transaction);
        }

        public async Task<int> DeleteAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await Connection.DeleteMultipleAsync(predicate, Transaction);
        }


    }


}