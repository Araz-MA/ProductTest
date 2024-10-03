using CleanArchitecture.Application.Common.Interfaces.IUnitOfWork.Dapper.IRepositories;

namespace CleanArchitecture.Application.Common.Interfaces.IUnitOfWork.Dapper
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}