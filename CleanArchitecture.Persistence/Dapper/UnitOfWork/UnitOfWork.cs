// Programmer : Mehdi Ahmadiyan Kaji -- Date : 1400/04/16 -- Time : 08:22 ق.ظ

using System.Data;
using CleanArchitecture.Application.Common.Interfaces.IUnitOfWork.Dapper;
using CleanArchitecture.Application.Common.Interfaces.IUnitOfWork.Dapper.IRepositories;
using CleanArchitecture.Common.Utilities;
using CleanArchitecture.Domain.Enums;
using CleanArchitecture.Persistence.Dapper.Repositories;
using CleanArchitecture.Persistence.EFCore.Helper;
using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using MySqlConnector;
using Npgsql;

namespace CleanArchitecture.Persistence.Dapper.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {


        private string connectionString = string.Empty;
        private readonly IDbConnection _connection;
        private IDbTransaction _transaction;
   


        public UnitOfWork()
        {
            var databaseType = DefaultEFCoreSettings.defaultProviderType;

            switch (databaseType)
            {
                case ProviderType.SQLServer:
                    connectionString = ConfigurationReader.GetSqlConnectionString();
                    _connection = new SqlConnection(connectionString);
                    _connection.Open();
                    _transaction = _connection.BeginTransaction();
                    break;

                case ProviderType.SQLite:
                    connectionString = ConfigurationReader.GetSqliteConnectionString();
                    _connection = new SqliteConnection(connectionString);
                    _connection.Open();
                    _transaction = _connection.BeginTransaction();
                    break;
                case ProviderType.PostgreSQL:
                    connectionString = ConfigurationReader.GetPostgreSQLConnectionString();
                    _connection = new NpgsqlConnection(connectionString);
                    _connection.Open();
                    _transaction = _connection.BeginTransaction();
                    break;

                case ProviderType.MySQL:
                    connectionString = ConfigurationReader.GetMySqlConnectionString();
                    _connection = new MySqlConnection(connectionString);
                    _connection.Open();
                    _transaction = _connection.BeginTransaction();
                    break;

            }
        }

       

        public void Commit()
        {
            try
            {
                _transaction.Commit();
            }
            catch
            {
                _transaction.Rollback();
                throw;
            }
            finally
            {
                _transaction.Dispose();
                _transaction = _connection.BeginTransaction();
                ResetRepositories();
            }
        }

        private void ResetRepositories()
        {
            
        }

        public void Dispose()
        {

        }
    }
}