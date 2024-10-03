using CleanArchitecture.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities.AppEntities.RangarangEnitities
{
    public class Product : IBaseEntity
    {
        public int Id { get; set; }
        public int ProductGroupId { get; set; }
        public int WorkTypeId { get; set; }
        public byte ProductType { get; set; }
        public string Circulation { get; set; }
        public string CopyCount { get; set; }
        public string PageCount { get; set; }
        public byte PrintSide { get; set; }
        public bool IsDelete { get; set; }
        public bool IsCalculatePrice { get; set; }
        public bool IsCustomCirculation { get; set; }
        public bool IsCustomSize { get; set; }
        public bool IsCustomPage { get; set; }
        public int MinCirculation { get; set; }
        public int MaxCirculation { get; set; }
        public int MinPage { get; set; }
        public int MaxPage { get; set; }
        public float MinWidth { get; set; }
        public float MaxWidth { get; set; }
        public float MinLength { get; set; }
        public float MaxLength { get; set; }
        public int SheetDimensionId { get; set; }
        public string FileExtension { get; set; }
        public bool IsCmyk { get; set; }
        public float cutMargin { get; set; }
        public float printMargin { get; set; }
        public bool IsCheckFile { get; set; }



        //  Relations

        public ICollection<ProductDeliver> ProductDelivers { get; set; }
        public ICollection<ProductMaterial> ProductMaterials { get; set; }
        public ICollection<ProductSize> ProductSizes { get; set; }
        public ICollection<ProductPrintKind>  ProductPrintKinds { get; set; }
        public ICollection<ProductAdt>  ProductAdts{ get; set; }
        
    }
}
