using GeekShopping.ProductAPI.Data.ValueObjects.BaseVO;

namespace GeekShopping.ProductAPI.Data.ValueObjects
{
    public class ProductVO : BaseEntityVO
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string ImageURL { get; set; }
    }
}
