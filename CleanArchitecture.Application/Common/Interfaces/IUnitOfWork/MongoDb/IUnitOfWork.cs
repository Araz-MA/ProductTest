using CleanArchitecture.Application.Common.Interfaces.IUnitOfWork.Dapper.IRepositories;

namespace CleanArchitecture.Application.Common.Interfaces.IUnitOfWork.Dapper
{
    public interface IMongoUnitOfWork : IDisposable
    {
        Task<bool> Commit();
    }
}