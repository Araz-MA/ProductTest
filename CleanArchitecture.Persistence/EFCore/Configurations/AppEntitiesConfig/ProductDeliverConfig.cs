﻿using CleanArchitecture.Common.Utilities;
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
    public class ProductDeliverConfig : IEntityTypeConfiguration<ProductDeliver>
    {        
        public void Configure(EntityTypeBuilder<ProductDeliver> builder)
        {
            builder.ToTable(TableNameCreator.CreateTableName(nameof(ProductDeliver)));

            builder.Property(x => x.Name).HasMaxLength(50);
            builder.Property(x => x.IsIncreased).HasDefaultValue(true);

            builder.HasMany(x => x.ProductDeliverSizes)
                .WithOne(x => x.ProductDeliver)
                .HasForeignKey(x => x.ProductDeliverId)
                          .OnDelete(DeleteBehavior.NoAction);


        }

    }
}




