namespace MiniStore.Database
{
    public class Product
    {
        public int Id { get; set; }
        public int ProductSubcategoryId { get; set; }
        public int ProductModelId { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public string Color { get; set; }
        public double ListPrice { get; set; }
        public string Size { get; set; }
        public string SizeUnitMeasureCode { get; set; }
        public string WeightUnitMeasureCode { get; set; }
        public double? Weight { get; set; }

        public ProductSubCategory ProductSubCategory { get; set; }
        public ProductModel ProductModel { get; set; }


    }
}