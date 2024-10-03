using CleanArchitecture.Domain.Entities.Base;

namespace CleanArchitecture.Domain.Entities.AppEntities.RangarangEnitities
{
    public class ProductDeliverSize : IBaseEntity
    {
        public int Id { get; set; }
   
        public ProductDeliver ProductDeliver { get; set; }
        public int ProductDeliverId { get; set; }

        public ProductSize ProductSize{ get; set; }
        public int ProductSizeId { get; set; }
    }
}
