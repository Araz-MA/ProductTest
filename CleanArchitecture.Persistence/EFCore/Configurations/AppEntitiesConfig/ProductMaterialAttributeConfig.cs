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
    public class ProductMaterialAttributeConfig : IEntityTypeConfiguration<ProductMaterialAttribute>
    {
        public void Configure(EntityTypeBuilder<ProductMaterialAttribute> builder)
        {
            builder.ToTable(TableNameCreator.CreateTableName(nameof(ProductMaterialAttribute)));

            builder.HasMany(x => x.ProductPrices)
                .WithOne(x => x.ProductMaterialAttribute)
                .HasForeignKey(x => x.ProductMaterialAttributeId)
                .OnDelete(DeleteBehavior.NoAction);




        }

    }
}




