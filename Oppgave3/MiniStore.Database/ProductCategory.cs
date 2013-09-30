using System.Collections.Generic;

namespace MiniStore.Database
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public object Name { get; set; }

        public List<ProductSubCategory> ProductSubCategory { get; set; }

        public ProductCategory()
        {
            ProductSubCategory = new List<ProductSubCategory>();
        }
    }
}