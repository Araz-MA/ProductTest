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
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(TableNameCreator.CreateTableName(nameof(Product)));

            builder.Property(x => x.Circulation).HasColumnType("nvarchar(MAX)");
            builder.Property(x => x.CopyCount).HasColumnType("nvarchar(MAX)");
            builder.Property(x => x.PageCount).HasColumnType("nvarchar(MAX)");
            builder.Property(x => x.FileExtension).HasMaxLength(50);

            builder.HasMany(x => x.ProductDelivers)
                .WithOne(x => x.Product)
                .HasForeignKey(x => x.ProductId);

            builder.HasMany(x => x.ProductSizes)
                .WithOne(x => x.Product)
                .HasForeignKey(x => x.ProductId);

            builder.HasMany(x => x.ProductMaterials)
                .WithOne(x => x.Product)
                .HasForeignKey(x => x.ProductId);

            builder.HasMany(x => x.ProductMaterials)
                     .WithOne(x => x.Product)
                     .HasForeignKey(x => x.ProductId);

            builder.HasMany(x => x.ProductAdts)
                .WithOne(x => x.Product)
                .HasForeignKey(x => x.ProductId);
        }

    }
}




