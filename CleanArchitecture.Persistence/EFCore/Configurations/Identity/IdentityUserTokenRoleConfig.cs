using CleanArchitecture.Common.Utilities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Persistence.EFCore.Configurations.Identity
{
    public class IdentityUserTokenRoleConfig : IEntityTypeConfiguration<IdentityUserToken<int>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserToken<int>> builder)
        {
            builder.ToTable(TableNameCreator.CreateTableName(nameof(IdentityUserToken<int>)));
        }
    }
}




