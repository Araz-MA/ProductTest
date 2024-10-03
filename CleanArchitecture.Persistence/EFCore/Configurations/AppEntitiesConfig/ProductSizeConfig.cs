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
    public class ProductSizeConfig : IEntityTypeConfiguration<ProductSize>
    {
        public void Configure(EntityTypeBuilder<ProductSize> builder)
        {
            builder.ToTable(TableNameCreator.CreateTableName(nameof(ProductSize)));

            builder.Property(x => x.Name).HasMaxLength(50);

            builder.HasMany(x => x.ProductDeliverSizes)
                .WithOne(x => x.ProductSize)
                .HasForeignKey(x => x.ProductSizeId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.ProductPrices)
                .WithOne(x => x.ProductSize)
                .HasForeignKey(x => x.ProductSizeId)
                 .OnDelete(DeleteBehavior.NoAction);


        }

    }
}




