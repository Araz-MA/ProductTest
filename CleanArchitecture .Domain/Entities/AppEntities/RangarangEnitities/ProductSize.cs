using CleanArchitecture.Domain.Entities.Base;

namespace CleanArchitecture.Domain.Entities.AppEntities.RangarangEnitities
{
    public class ProductSize : IBaseEntity
    {
        public int Id { get; set; } 
        public bool length { get; set; }
        public bool width { get; set; }
        public string Name { get; set; }
        public int SheetCount { get; set; }
        public int sheetDimensionId { get; set; }


        public Product Product { get; set; }
        public int ProductId { get; set; }


        public ICollection<ProductDeliverSize> ProductDeliverSizes { get; set; }
        public ICollection<ProductPrice> ProductPrices { get; set; }
    }
}
