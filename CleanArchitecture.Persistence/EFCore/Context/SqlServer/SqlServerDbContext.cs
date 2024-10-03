using CleanArchitecture.Application.Common.Interfaces.IUnitOfWork.EFCore;
using CleanArchitecture.Domain.Entities.IdentityEntities;
using CleanArchitecture.Persistence.EFCore.Configurations.AppEntitiesConfig;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistence.EFCore.Context.SqlServer
{
    public class SqlServerDbContext : IdentityDbContext<User, Role, int>, IDatabaseContext
    {
        public SqlServerDbContext(DbContextOptions<SqlServerDbContext> options)
            : base(options)
        {
        }
        public void Migrate()
        {
            if (Database.GetPendingMigrations().Count() > 0)
            {
                Database.Migrate();
            }
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
        }
 
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(ProductConfig).Assembly);
        }
    }
}
