using CleanArchitecture.Domain.Entities.Base;

namespace CleanArchitecture.Domain.Entities.AppEntities.RangarangEnitities
{
    public class ProductMaterialAttribute : IBaseEntity
    {
        public int Id { get; set; }
        public int productMaterialId { get; set; }


        public ProductMaterial ProductMaterial { get; set; }
        public int MaterialAttributeId { get; set; }




        public ICollection<ProductPrice> ProductPrices { get; set; }

    }
}
