using CleanArchitecture.Common.Utilities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Persistence.EFCore.Configurations.Identity
{
    public class IdentityRoleClaimRoleConfig : IEntityTypeConfiguration<IdentityRoleClaim<int>>
    {
        public void Configure(EntityTypeBuilder<IdentityRoleClaim<int>> builder)
        {
            builder.ToTable(TableNameCreator.CreateTableName(nameof(IdentityRoleClaim<int>)));
        }
    }
}




