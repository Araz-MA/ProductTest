using CleanArchitecture.Domain.Entities.Base;

namespace CleanArchitecture.Domain.Entities.AppEntities.RangarangEnitities
{
    public class ProductAdtType : IBaseEntity
    {
        public int Id { get; set; }    
        public int AdtTypeId { get; set; }

        public ProductAdt ProductAdt { get; set; }
        public int ProductAdtId { get; set; }


        public ICollection<ProductAdtPrice> ProductAdtPrices { get; set; }
    }
}
