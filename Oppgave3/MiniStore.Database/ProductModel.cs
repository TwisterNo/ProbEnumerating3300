using System.Collections.Generic;

namespace MiniStore.Database
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public List<Product>  Products { get; set; }

        public ProductModel()
        {
            Products = new List<Product>();
        }
    }

}
