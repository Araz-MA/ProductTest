using CleanArchitecture.Domain.Entities.Base;

namespace CleanArchitecture.Domain.Entities.AppEntities.RangarangEnitities
{
    public class ProductAdt : IBaseEntity
    {
        public int Id { get; set; }
        public int AdtId { get; set; }
        public bool Required { get; set; }
        public byte Side { get; set; }
        public int Count { get; set; }
        public int IsJeld { get; set; }

        public Product Product { get; set; }
        public int ProductId { get; set; }

        public ICollection<ProductAdtPrice> ProductAdtPrices { get; set; }
        public ICollection<ProductAdtType> ProductAdtTypes { get; set; }
    }
}
