using CleanArchitecture.Application.Common.Interfaces.IUnitOfWork.EFCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CleanArchitecture.Persistence.Dapper.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using CleanArchitecture.Domain.Enums;
using Dapper.FluentMap.Dommel;
using Dapper.FluentMap;
using CleanArchitecture.Persistence.EFCore.Context.SqlServer;
using CleanArchitecture.Persistence.EFCore.Helper;
using CleanArchitecture.Persistence.Dapper.Repositories.Base;
using CleanArchitecture.Application.Common.Interfaces.IUnitOfWork.Dapper;
using CleanArchitecture.Application.Common.Interfaces.IUnitOfWork.Dapper.IRepositories.Base;
using CleanArchitecture.Common.Utilities;

namespace CleanArchitecture.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {

            FluentMapper.Initialize(config =>
            {                
                config.ForDommel();
            });



            services.AddScoped<IUnitOfWork, UnitOfWork>();    
            
            services.AddScoped(typeof(ICrudRepository<,>), typeof(CrudRepository<,>));            

            var databaseType = DefaultEFCoreSettings.defaultProviderType;

            switch (databaseType)
            {
                case ProviderType.SQLServer:
                    services.AddScoped<IDatabaseContext, SqlServerDbContext>();
                    services.AddDbContextPool<SqlServerDbContext>(options =>
                    {
                        options.UseSqlServer(ConfigurationReader.GetSqlConnectionString(), dbOptions =>
                        {
                            var minutes = (int)TimeSpan.FromMinutes(3).TotalSeconds;
                            dbOptions.CommandTimeout(minutes);
                            dbOptions.EnableRetryOnFailure();
                        })
                        .LogTo(Console.WriteLine, LogLevel.Information);
                    });
                    break;

                case ProviderType.SQLite:
                    
                    break;
                case ProviderType.PostgreSQL:
                    
                    break;

                case ProviderType.MySQL:
                     
                    break;

            }
        }
    }
}
