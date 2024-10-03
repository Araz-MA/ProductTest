using CleanArchitecture.Common.Utilities;
using CleanArchitecture.Domain.Entities.AppEntities;
using CleanArchitecture.Domain.Entities.AppEntities.RangarangEnitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Persistence.EFCore.Configurations.AppEntitiesConfig
{
    public class ProductAdtConfig : IEntityTypeConfiguration<ProductAdt>
    {
        public void Configure(EntityTypeBuilder<ProductAdt> builder)
        {
            builder.ToTable(TableNameCreator.CreateTableName(nameof(ProductAdt)));

            builder.HasMany(x => x.ProductAdtPrices)
                .WithOne(x => x.ProductAdt)
                .HasForeignKey(x => x.ProductAdtId)
                .OnDelete(DeleteBehavior.NoAction);


            builder.HasMany(x => x.ProductAdtTypes)
                       .WithOne(x => x.ProductAdt)
                       .HasForeignKey(x => x.ProductAdtId)
                .OnDelete(DeleteBehavior.NoAction);

        }

    }
}




