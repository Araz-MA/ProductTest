using CleanArchitecture.Domain.Entities.Base;

namespace CleanArchitecture.Domain.Entities.AppEntities.RangarangEnitities
{
    public class ProductAdtPrice : IBaseEntity
    {
        public int Id { get; set; } 
        public int Price { get; set; }    


        public ProductPrice ProductPrice { get; set; }
        public int ProductPriceId { get; set; }

        public ProductAdt ProductAdt { get; set; }
        public int ProductAdtId { get; set; }

        public ProductAdtType ProductAdtType { get; set; }
        public int ProductAdtTypeId { get; set; }        
    }
}
