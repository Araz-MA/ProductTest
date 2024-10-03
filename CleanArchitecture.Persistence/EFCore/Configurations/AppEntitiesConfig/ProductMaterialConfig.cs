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
    public class ProductMaterialConfig : IEntityTypeConfiguration<ProductMaterial>
    {
        public void Configure(EntityTypeBuilder<ProductMaterial> builder)
        {
            builder.ToTable(TableNameCreator.CreateTableName(nameof(ProductMaterial)));

            builder.Property(x => x.Name).HasMaxLength(50);

            builder.HasMany(x => x.ProductPrices)
                .WithOne(x => x.ProductMaterial)
                .HasForeignKey(x => x.ProductMaterialId)
                .OnDelete(DeleteBehavior.NoAction);



            builder.HasMany(x => x.ProductMaterialAttributes)
                    .WithOne(x => x.ProductMaterial)
                    .HasForeignKey(x => x.MaterialAttributeId)
                .OnDelete(DeleteBehavior.NoAction);
        }

    }
}




