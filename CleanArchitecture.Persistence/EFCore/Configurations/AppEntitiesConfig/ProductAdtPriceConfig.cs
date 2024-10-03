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
    public class ProductAdtPriceConfig : IEntityTypeConfiguration<ProductAdtPrice>
    {
        public void Configure(EntityTypeBuilder<ProductAdtPrice> builder)
        {
            builder.ToTable(TableNameCreator.CreateTableName(nameof(ProductAdtPrice)));

            

        }

    }
}




