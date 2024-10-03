using CleanArchitecture.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities.AppEntities.RangarangEnitities
{
    public class ProductMaterial : IBaseEntity
    {
        public int Id { get; set; }
        public int MaterialId { get; set; }
        public string Name { get; set; }
        public bool IsJeld { get; set; }
        public bool Required { get; set; }
        public bool IsCustomCirculation { get; set; }
        public bool IsCombinedMaterial { get; set; }
        public int Weight { get; set; }

        public Product Product { get; set; }
        public int ProductId { get; set; }


        public ICollection<ProductMaterialAttribute> ProductMaterialAttributes { get; set; }
        public ICollection<ProductPrice> ProductPrices { get; set; }

    }
}
