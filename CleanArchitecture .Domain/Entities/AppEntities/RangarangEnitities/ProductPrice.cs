using CleanArchitecture.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities.AppEntities.RangarangEnitities
{
    public class ProductPrice : IBaseEntity
    {
        public int Id { get; set; }
        public float Price { get; set; }
        public int Circulation { get; set; }
        public bool IsDoubleSided { get; set; }
        public int PageCount { get; set; }
        public int CopyCount { get; set; }      
        public bool IsJeld { get; set; }
        



        public ProductPrintKind ProductPrintKind{ get; set; }
        public int ProductPrintKindId { get; set; }

        public ProductMaterial ProductMaterial { get; set; }
        public int ProductMaterialId { get; set; }


        public ProductSize ProductSize { get; set; }     
        public int ProductSizeId { get; set; }


        public ProductMaterialAttribute ProductMaterialAttribute { get; set; }
        public int? ProductMaterialAttributeId { get; set; }


        public ICollection<ProductAdtPrice> ProductAdtPrices { get; set; }
    }
}
