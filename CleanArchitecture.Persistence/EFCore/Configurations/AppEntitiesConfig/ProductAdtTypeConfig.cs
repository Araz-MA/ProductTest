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
    public class ProductAdtTypeConfig : IEntityTypeConfiguration<ProductAdtType>
    {
        public void Configure(EntityTypeBuilder<ProductAdtType> builder)
        {
            builder.ToTable(TableNameCreator.CreateTableName(nameof(ProductAdtType)));

            builder.HasMany(x => x.ProductAdtPrices)
                .WithOne(x => x.ProductAdtType)
                .HasForeignKey(x => x.ProductAdtTypeId)
                .OnDelete(DeleteBehavior.NoAction);


        }

    }
}




