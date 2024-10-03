using CleanArchitecture.Domain.Entities.Base;

namespace CleanArchitecture.Domain.Entities.AppEntities.RangarangEnitities
{
    public class ProductPrintKind : IBaseEntity
    {
        public int Id { get; set; }
        public int PrintKind { get; set; }
        public bool IsJeld { get; set; }


        public Product Product { get; set; }
        public int ProductId { get; set; }

        public ICollection<ProductPrice> ProductPrices { get; set; }
    }
}
