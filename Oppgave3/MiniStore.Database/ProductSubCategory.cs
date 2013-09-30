using System.Collections.Generic;

namespace MiniStore.Database
{
    public class ProductSubCategory
    {
        public int Id { get; set; }
        public int ProductCategoryId { get; set; }
        public string Name { get; set; }
        
        public ProductCategory ProductCategory { get; set; }
        public List<Product> Products { get; set; }

        public ProductSubCategory()
        {
            Products = new List<Product>();
        }
    }
}