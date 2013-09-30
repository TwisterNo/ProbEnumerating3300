using System.Collections.Generic;
using System.Linq;

namespace MiniStore.Database
{
    public static class ProductRepository
    {
        public static List<ProductCategory> ProductCategories { get; private set; }
        public static IEnumerable<ProductSubCategory> ProductSubCategories { get; private set; }
        public static IEnumerable<Product> Products { get; private set; }
        public static IEnumerable<ProductModel> ProductModels { get; private set; }

        static ProductRepository()
        {
            FillProductCategory();
            FillProductSubCategory();
            FIllProductModel();
            FillProductList();

            BuildMap();
        }

        private static void BuildMap()
        {
            foreach (var cat in ProductSubCategories)
            {
                cat.ProductCategory = ProductCategories.First(p => p.Id == cat.ProductCategoryId);
                cat.ProductCategory.ProductSubCategory.Add(cat);
            }

            foreach (var product in Products)
            {
                product.ProductSubCategory = ProductSubCategories.First(p => p.Id == product.ProductSubcategoryId);
                product.ProductSubCategory.Products.Add(product);
                product.ProductModel = ProductModels.First(p => p.Id == product.ProductModelId);
                product.ProductModel.Products.Add(product);
            }
        }


        private static void FillProductCategory()
        {
            ProductCategories = new List<ProductCategory>
            {
                new ProductCategory { 	Id = 4,	Name = "Accessories" },																																																												
                new ProductCategory { 	Id = 1,	Name = "Bikes" },																																																												
                new ProductCategory { 	Id = 3,	Name = "Clothing" },																																																												
                new ProductCategory { 	Id = 2,	Name = "Components" },																																																												
            };
        }

        private static void FillProductSubCategory()
        {
            ProductSubCategories = new List<ProductSubCategory>
            {
                new ProductSubCategory { 	Id = 1,	ProductCategoryId = 1,	Name = "Mountain Bikes" },																																																											
                new ProductSubCategory { 	Id = 2,	ProductCategoryId = 1,	Name = "Road Bikes" },																																																											
                new ProductSubCategory { 	Id = 3,	ProductCategoryId = 1,	Name = "Touring Bikes" },																																																											
                new ProductSubCategory { 	Id = 4,	ProductCategoryId = 2,	Name = "Handlebars" },																																																											
                new ProductSubCategory { 	Id = 5,	ProductCategoryId = 2,	Name = "Bottom Brackets" },																																																											
                new ProductSubCategory { 	Id = 6,	ProductCategoryId = 2,	Name = "Brakes" },																																																											
                new ProductSubCategory { 	Id = 7,	ProductCategoryId = 2,	Name = "Chains" },																																																											
                new ProductSubCategory { 	Id = 8,	ProductCategoryId = 2,	Name = "Cranksets" },																																																											
                new ProductSubCategory { 	Id = 9,	ProductCategoryId = 2,	Name = "Derailleurs" },																																																											
                new ProductSubCategory { 	Id = 10,	ProductCategoryId = 2,	Name = "Forks" },																																																											
                new ProductSubCategory { 	Id = 11,	ProductCategoryId = 2,	Name = "Headsets" },																																																											
                new ProductSubCategory { 	Id = 12,	ProductCategoryId = 2,	Name = "Mountain Frames" },																																																											
                new ProductSubCategory { 	Id = 13,	ProductCategoryId = 2,	Name = "Pedals" },																																																											
                new ProductSubCategory { 	Id = 14,	ProductCategoryId = 2,	Name = "Road Frames" },																																																											
                new ProductSubCategory { 	Id = 15,	ProductCategoryId = 2,	Name = "Saddles" },																																																											
                new ProductSubCategory { 	Id = 16,	ProductCategoryId = 2,	Name = "Touring Frames" },																																																											
                new ProductSubCategory { 	Id = 17,	ProductCategoryId = 2,	Name = "Wheels" },																																																											
                new ProductSubCategory { 	Id = 18,	ProductCategoryId = 3,	Name = "Bib-Shorts" },																																																											
                new ProductSubCategory { 	Id = 19,	ProductCategoryId = 3,	Name = "Caps" },																																																											
                new ProductSubCategory { 	Id = 20,	ProductCategoryId = 3,	Name = "Gloves" },																																																											
                new ProductSubCategory { 	Id = 21,	ProductCategoryId = 3,	Name = "Jerseys" },																																																											
                new ProductSubCategory { 	Id = 22,	ProductCategoryId = 3,	Name = "Shorts" },																																																											
                new ProductSubCategory { 	Id = 23,	ProductCategoryId = 3,	Name = "Socks" },																																																											
                new ProductSubCategory { 	Id = 24,	ProductCategoryId = 3,	Name = "Tights" },																																																											
                new ProductSubCategory { 	Id = 25,	ProductCategoryId = 3,	Name = "Vests" },																																																											
                new ProductSubCategory { 	Id = 26,	ProductCategoryId = 4,	Name = "Bike Racks" },																																																											
                new ProductSubCategory { 	Id = 27,	ProductCategoryId = 4,	Name = "Bike Stands" },																																																											
                new ProductSubCategory { 	Id = 28,	ProductCategoryId = 4,	Name = "Bottles and Cages" },																																																											
                new ProductSubCategory { 	Id = 29,	ProductCategoryId = 4,	Name = "Cleaners" },																																																											
                new ProductSubCategory { 	Id = 30,	ProductCategoryId = 4,	Name = "Fenders" },																																																											
                new ProductSubCategory { 	Id = 31,	ProductCategoryId = 4,	Name = "Helmets" },																																																											
                new ProductSubCategory { 	Id = 32,	ProductCategoryId = 4,	Name = "Hydration Packs" },																																																											
                new ProductSubCategory { 	Id = 33,	ProductCategoryId = 4,	Name = "Lights" },																																																											
                new ProductSubCategory { 	Id = 34,	ProductCategoryId = 4,	Name = "Locks" },																																																											
                new ProductSubCategory { 	Id = 35,	ProductCategoryId = 4,	Name = "Panniers" },																																																											
                new ProductSubCategory { 	Id = 36,	ProductCategoryId = 4,	Name = "Pumps" },																																																											
                new ProductSubCategory { 	Id = 37,	ProductCategoryId = 4,	Name = "Tires and Tubes" },																																																											
            };
        }

        private static void FIllProductModel()
        {
            ProductModels = new List<ProductModel>
            {
                new ProductModel {Id = 122, Name = "All-Purpose Bike Stand"},
                new ProductModel {Id = 119, Name = "Bike Wash"},
                new ProductModel {Id = 115, Name = "Cable Lock"},
                new ProductModel {Id = 98, Name = "Chain"},
                new ProductModel {Id = 1, Name = "Classic Vest"},
                new ProductModel {Id = 2, Name = "Cycling Cap"},
                new ProductModel {Id = 121, Name = "Fender Set - Mountain"},
                new ProductModel {Id = 102, Name = "Front Brakes"},
                new ProductModel {Id = 103, Name = "Front Derailleur"},
                new ProductModel {Id = 3, Name = "Full-Finger Gloves"},
                new ProductModel {Id = 4, Name = "Half-Finger Gloves"},
                new ProductModel {Id = 109, Name = "Headlights - Dual-Beam"},
                new ProductModel {Id = 110, Name = "Headlights - Weatherproof"},
                new ProductModel {Id = 118, Name = "Hitch Rack - 4-Bike"},
                new ProductModel {Id = 97, Name = "HL Bottom Bracket"},
                new ProductModel {Id = 101, Name = "HL Crankset"},
                new ProductModel {Id = 106, Name = "HL Fork"},
                new ProductModel {Id = 61, Name = "HL Headset"},
                new ProductModel {Id = 5, Name = "HL Mountain Frame"},
                new ProductModel {Id = 46, Name = "HL Mountain Front Wheel"},
                new ProductModel {Id = 55, Name = "HL Mountain Handlebars"},
                new ProductModel {Id = 64, Name = "HL Mountain Pedal"},
                new ProductModel {Id = 125, Name = "HL Mountain Rear Wheel"},
                new ProductModel {Id = 73, Name = "HL Mountain Seat/Saddle 1"},
                new ProductModel {Id = 81, Name = "HL Mountain Seat/Saddle 2"},
                new ProductModel {Id = 87, Name = "HL Mountain Tire"},
                new ProductModel {Id = 6, Name = "HL Road Frame"},
                new ProductModel {Id = 51, Name = "HL Road Front Wheel"},
                new ProductModel {Id = 58, Name = "HL Road Handlebars"},
                new ProductModel {Id = 70, Name = "HL Road Pedal"},
                new ProductModel {Id = 78, Name = "HL Road Rear Wheel"},
                new ProductModel {Id = 76, Name = "HL Road Seat/Saddle 1"},
                new ProductModel {Id = 84, Name = "HL Road Seat/Saddle 2"},
                new ProductModel {Id = 90, Name = "HL Road Tire"},
                new ProductModel {Id = 7, Name = "HL Touring Frame"},
                new ProductModel {Id = 48, Name = "HL Touring Handlebars"},
                new ProductModel {Id = 67, Name = "HL Touring Seat/Saddle"},
                new ProductModel {Id = 107, Name = "Hydration Pack"},
                new ProductModel {Id = 95, Name = "LL Bottom Bracket"},
                new ProductModel {Id = 99, Name = "LL Crankset"},
                new ProductModel {Id = 104, Name = "LL Fork"},
                new ProductModel {Id = 59, Name = "LL Headset"},
                new ProductModel {Id = 8, Name = "LL Mountain Frame"},
                new ProductModel {Id = 42, Name = "LL Mountain Front Wheel"},
                new ProductModel {Id = 52, Name = "LL Mountain Handlebars"},
                new ProductModel {Id = 62, Name = "LL Mountain Pedal"},
                new ProductModel {Id = 123, Name = "LL Mountain Rear Wheel"},
                new ProductModel {Id = 71, Name = "LL Mountain Seat/Saddle 1"},
                new ProductModel {Id = 79, Name = "LL Mountain Seat/Saddle 2"},
                new ProductModel {Id = 85, Name = "LL Mountain Tire"},
                new ProductModel {Id = 9, Name = "LL Road Frame"},
                new ProductModel {Id = 49, Name = "LL Road Front Wheel"},
                new ProductModel {Id = 56, Name = "LL Road Handlebars"},
                new ProductModel {Id = 68, Name = "LL Road Pedal"},
                new ProductModel {Id = 126, Name = "LL Road Rear Wheel"},
                new ProductModel {Id = 82, Name = "LL Road Seat/Saddle 1"},
                new ProductModel {Id = 74, Name = "LL Road Seat/Saddle 2"},
                new ProductModel {Id = 88, Name = "LL Road Tire"},
                new ProductModel {Id = 10, Name = "LL Touring Frame"},
                new ProductModel {Id = 47, Name = "LL Touring Handlebars"},
                new ProductModel {Id = 66, Name = "LL Touring Seat/Saddle"},
                new ProductModel {Id = 11, Name = "Long-Sleeve Logo Jersey"},
                new ProductModel {Id = 12, Name = "Men's Bib-Shorts"},
                new ProductModel {Id = 13, Name = "Men's Sports Shorts"},
                new ProductModel {Id = 116, Name = "Minipump"},
                new ProductModel {Id = 96, Name = "ML Bottom Bracket"},
                new ProductModel {Id = 100, Name = "ML Crankset"},
                new ProductModel {Id = 105, Name = "ML Fork"},
                new ProductModel {Id = 60, Name = "ML Headset"},
                new ProductModel {Id = 14, Name = "ML Mountain Frame"},
                new ProductModel {Id = 15, Name = "ML Mountain Frame-W"},
                new ProductModel {Id = 45, Name = "ML Mountain Front Wheel"},
                new ProductModel {Id = 54, Name = "ML Mountain Handlebars"},
                new ProductModel {Id = 63, Name = "ML Mountain Pedal"},
                new ProductModel {Id = 124, Name = "ML Mountain Rear Wheel"},
                new ProductModel {Id = 72, Name = "ML Mountain Seat/Saddle 1"},
                new ProductModel {Id = 80, Name = "ML Mountain Seat/Saddle 2"},
                new ProductModel {Id = 86, Name = "ML Mountain Tire"},
                new ProductModel {Id = 16, Name = "ML Road Frame"},
                new ProductModel {Id = 17, Name = "ML Road Frame-W"},
                new ProductModel {Id = 50, Name = "ML Road Front Wheel"},
                new ProductModel {Id = 57, Name = "ML Road Handlebars"},
                new ProductModel {Id = 69, Name = "ML Road Pedal"},
                new ProductModel {Id = 77, Name = "ML Road Rear Wheel"},
                new ProductModel {Id = 75, Name = "ML Road Seat/Saddle 1"},
                new ProductModel {Id = 83, Name = "ML Road Seat/Saddle 2"},
                new ProductModel {Id = 89, Name = "ML Road Tire"},
                new ProductModel {Id = 65, Name = "ML Touring Seat/Saddle"},
                new ProductModel {Id = 18, Name = "Mountain Bike Socks"},
                new ProductModel {Id = 112, Name = "Mountain Bottle Cage"},
                new ProductModel {Id = 117, Name = "Mountain Pump"},
                new ProductModel {Id = 92, Name = "Mountain Tire Tube"},
                new ProductModel {Id = 19, Name = "Mountain-100"},
                new ProductModel {Id = 20, Name = "Mountain-200"},
                new ProductModel {Id = 21, Name = "Mountain-300"},
                new ProductModel {Id = 39, Name = "Mountain-400"},
                new ProductModel {Id = 22, Name = "Mountain-400-W"},
                new ProductModel {Id = 23, Name = "Mountain-500"},
                new ProductModel {Id = 114, Name = "Patch kit"},
                new ProductModel {Id = 24, Name = "Racing Socks"},
                new ProductModel {Id = 128, Name = "Rear Brakes"},
                new ProductModel {Id = 127, Name = "Rear Derailleur"},
                new ProductModel {Id = 113, Name = "Road Bottle Cage"},
                new ProductModel {Id = 93, Name = "Road Tire Tube"},
                new ProductModel {Id = 25, Name = "Road-150"},
                new ProductModel {Id = 26, Name = "Road-250"},
                new ProductModel {Id = 41, Name = "Road-350"},
                new ProductModel {Id = 27, Name = "Road-350-W"},
                new ProductModel {Id = 28, Name = "Road-450"},
                new ProductModel {Id = 40, Name = "Road-550"},
                new ProductModel {Id = 29, Name = "Road-550-W"},
                new ProductModel {Id = 30, Name = "Road-650"},
                new ProductModel {Id = 31, Name = "Road-750"},
                new ProductModel {Id = 32, Name = "Short-Sleeve Classic Jersey"},
                new ProductModel {Id = 33, Name = "Sport-100"},
                new ProductModel {Id = 108, Name = "Taillight"},
                new ProductModel {Id = 44, Name = "Touring Front Wheel"},
                new ProductModel {Id = 53, Name = "Touring Pedal"},
                new ProductModel {Id = 43, Name = "Touring Rear Wheel"},
                new ProductModel {Id = 91, Name = "Touring Tire"},
                new ProductModel {Id = 94, Name = "Touring Tire Tube"},
                new ProductModel {Id = 34, Name = "Touring-1000"},
                new ProductModel {Id = 35, Name = "Touring-2000"},
                new ProductModel {Id = 36, Name = "Touring-3000"},
                new ProductModel {Id = 120, Name = "Touring-Panniers"},
                new ProductModel {Id = 111, Name = "Water Bottle"},
                new ProductModel {Id = 37, Name = "Women's Mountain Shorts"},
                new ProductModel {Id = 38, Name = "Women's Tights"},
            };
        }

        private static void FillProductList()
        {
            Products = new List<Product>
            {
                new Product
                {
                    Id = 680,
                    ProductSubcategoryId = 14,
                    ProductModelId = 6,
                    Name = "HL Road Frame - Black, 58",
                    ProductNumber = "FR-R92B-58",
                    Color = "Black",
                    ListPrice = 1431.5,
                    Size = "58",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 45323
                },
                new Product
                {
                    Id = 706,
                    ProductSubcategoryId = 14,
                    ProductModelId = 6,
                    Name = "HL Road Frame - Red, 58",
                    ProductNumber = "FR-R92R-58",
                    Color = "Red",
                    ListPrice = 1431.5,
                    Size = "58",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 45323
                },
                new Product
                {
                    Id = 707,
                    ProductSubcategoryId = 31,
                    ProductModelId = 33,
                    Name = "Sport-100 Helmet, Red",
                    ProductNumber = "HL-U509-R",
                    Color = "Red",
                    ListPrice = 34.99,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 708,
                    ProductSubcategoryId = 31,
                    ProductModelId = 33,
                    Name = "Sport-100 Helmet, Black",
                    ProductNumber = "HL-U509",
                    Color = "Black",
                    ListPrice = 34.99,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 709,
                    ProductSubcategoryId = 23,
                    ProductModelId = 18,
                    Name = "Mountain Bike Socks, M",
                    ProductNumber = "SO-B909-M",
                    Color = "White",
                    ListPrice = 9.5,
                    Size = "M",
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 710,
                    ProductSubcategoryId = 23,
                    ProductModelId = 18,
                    Name = "Mountain Bike Socks, L",
                    ProductNumber = "SO-B909-L",
                    Color = "White",
                    ListPrice = 9.5,
                    Size = "L",
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 711,
                    ProductSubcategoryId = 31,
                    ProductModelId = 33,
                    Name = "Sport-100 Helmet, Blue",
                    ProductNumber = "HL-U509-B",
                    Color = "Blue",
                    ListPrice = 34.99,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 712,
                    ProductSubcategoryId = 19,
                    ProductModelId = 2,
                    Name = "AWC Logo Cap",
                    ProductNumber = "CA-1098",
                    Color = "Multi",
                    ListPrice = 8.99,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 713,
                    ProductSubcategoryId = 21,
                    ProductModelId = 11,
                    Name = "Long-Sleeve Logo Jersey, S",
                    ProductNumber = "LJ-0192-S",
                    Color = "Multi",
                    ListPrice = 49.99,
                    Size = "S",
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 714,
                    ProductSubcategoryId = 21,
                    ProductModelId = 11,
                    Name = "Long-Sleeve Logo Jersey, M",
                    ProductNumber = "LJ-0192-M",
                    Color = "Multi",
                    ListPrice = 49.99,
                    Size = "M",
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 715,
                    ProductSubcategoryId = 21,
                    ProductModelId = 11,
                    Name = "Long-Sleeve Logo Jersey, L",
                    ProductNumber = "LJ-0192-L",
                    Color = "Multi",
                    ListPrice = 49.99,
                    Size = "L",
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 716,
                    ProductSubcategoryId = 21,
                    ProductModelId = 11,
                    Name = "Long-Sleeve Logo Jersey, XL",
                    ProductNumber = "LJ-0192-X",
                    Color = "Multi",
                    ListPrice = 49.99,
                    Size = "XL",
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 717,
                    ProductSubcategoryId = 14,
                    ProductModelId = 6,
                    Name = "HL Road Frame - Red, 62",
                    ProductNumber = "FR-R92R-62",
                    Color = "Red",
                    ListPrice = 1431.5,
                    Size = "62",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 10990
                },
                new Product
                {
                    Id = 718,
                    ProductSubcategoryId = 14,
                    ProductModelId = 6,
                    Name = "HL Road Frame - Red, 44",
                    ProductNumber = "FR-R92R-44",
                    Color = "Red",
                    ListPrice = 1431.5,
                    Size = "44",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 41610
                },
                new Product
                {
                    Id = 719,
                    ProductSubcategoryId = 14,
                    ProductModelId = 6,
                    Name = "HL Road Frame - Red, 48",
                    ProductNumber = "FR-R92R-48",
                    Color = "Red",
                    ListPrice = 1431.5,
                    Size = "48",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 42401
                },
                new Product
                {
                    Id = 720,
                    ProductSubcategoryId = 14,
                    ProductModelId = 6,
                    Name = "HL Road Frame - Red, 52",
                    ProductNumber = "FR-R92R-52",
                    Color = "Red",
                    ListPrice = 1431.5,
                    Size = "52",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 43862
                },
                new Product
                {
                    Id = 721,
                    ProductSubcategoryId = 14,
                    ProductModelId = 6,
                    Name = "HL Road Frame - Red, 56",
                    ProductNumber = "FR-R92R-56",
                    Color = "Red",
                    ListPrice = 1431.5,
                    Size = "56",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 45323
                },
                new Product
                {
                    Id = 722,
                    ProductSubcategoryId = 14,
                    ProductModelId = 9,
                    Name = "LL Road Frame - Black, 58",
                    ProductNumber = "FR-R38B-58",
                    Color = "Black",
                    ListPrice = 337.22,
                    Size = "58",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 16834
                },
                new Product
                {
                    Id = 723,
                    ProductSubcategoryId = 14,
                    ProductModelId = 9,
                    Name = "LL Road Frame - Black, 60",
                    ProductNumber = "FR-R38B-60",
                    Color = "Black",
                    ListPrice = 337.22,
                    Size = "60",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 17564
                },
                new Product
                {
                    Id = 724,
                    ProductSubcategoryId = 14,
                    ProductModelId = 9,
                    Name = "LL Road Frame - Black, 62",
                    ProductNumber = "FR-R38B-62",
                    Color = "Black",
                    ListPrice = 337.22,
                    Size = "62",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 18295
                },
                new Product
                {
                    Id = 725,
                    ProductSubcategoryId = 14,
                    ProductModelId = 9,
                    Name = "LL Road Frame - Red, 44",
                    ProductNumber = "FR-R38R-44",
                    Color = "Red",
                    ListPrice = 337.22,
                    Size = "44",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 11720
                },
                new Product
                {
                    Id = 726,
                    ProductSubcategoryId = 14,
                    ProductModelId = 9,
                    Name = "LL Road Frame - Red, 48",
                    ProductNumber = "FR-R38R-48",
                    Color = "Red",
                    ListPrice = 337.22,
                    Size = "48",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 13181
                },
                new Product
                {
                    Id = 727,
                    ProductSubcategoryId = 14,
                    ProductModelId = 9,
                    Name = "LL Road Frame - Red, 52",
                    ProductNumber = "FR-R38R-52",
                    Color = "Red",
                    ListPrice = 337.22,
                    Size = "52",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 14642
                },
                new Product
                {
                    Id = 728,
                    ProductSubcategoryId = 14,
                    ProductModelId = 9,
                    Name = "LL Road Frame - Red, 58",
                    ProductNumber = "FR-R38R-58",
                    Color = "Red",
                    ListPrice = 337.22,
                    Size = "58",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 16834
                },
                new Product
                {
                    Id = 729,
                    ProductSubcategoryId = 14,
                    ProductModelId = 9,
                    Name = "LL Road Frame - Red, 60",
                    ProductNumber = "FR-R38R-60",
                    Color = "Red",
                    ListPrice = 337.22,
                    Size = "60",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 17564
                },
                new Product
                {
                    Id = 730,
                    ProductSubcategoryId = 14,
                    ProductModelId = 9,
                    Name = "LL Road Frame - Red, 62",
                    ProductNumber = "FR-R38R-62",
                    Color = "Red",
                    ListPrice = 337.22,
                    Size = "62",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 18295
                },
                new Product
                {
                    Id = 731,
                    ProductSubcategoryId = 14,
                    ProductModelId = 16,
                    Name = "ML Road Frame - Red, 44",
                    ProductNumber = "FR-R72R-44",
                    Color = "Red",
                    ListPrice = 594.83,
                    Size = "44",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 44593
                },
                new Product
                {
                    Id = 732,
                    ProductSubcategoryId = 14,
                    ProductModelId = 16,
                    Name = "ML Road Frame - Red, 48",
                    ProductNumber = "FR-R72R-48",
                    Color = "Red",
                    ListPrice = 594.83,
                    Size = "48",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 46054
                },
                new Product
                {
                    Id = 733,
                    ProductSubcategoryId = 14,
                    ProductModelId = 16,
                    Name = "ML Road Frame - Red, 52",
                    ProductNumber = "FR-R72R-52",
                    Color = "Red",
                    ListPrice = 594.83,
                    Size = "52",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 10990
                },
                new Product
                {
                    Id = 734,
                    ProductSubcategoryId = 14,
                    ProductModelId = 16,
                    Name = "ML Road Frame - Red, 58",
                    ProductNumber = "FR-R72R-58",
                    Color = "Red",
                    ListPrice = 594.83,
                    Size = "58",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 13181
                },
                new Product
                {
                    Id = 735,
                    ProductSubcategoryId = 14,
                    ProductModelId = 16,
                    Name = "ML Road Frame - Red, 60",
                    ProductNumber = "FR-R72R-60",
                    Color = "Red",
                    ListPrice = 594.83,
                    Size = "60",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 13912
                },
                new Product
                {
                    Id = 736,
                    ProductSubcategoryId = 14,
                    ProductModelId = 9,
                    Name = "LL Road Frame - Black, 44",
                    ProductNumber = "FR-R38B-44",
                    Color = "Black",
                    ListPrice = 337.22,
                    Size = "44",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 11720
                },
                new Product
                {
                    Id = 737,
                    ProductSubcategoryId = 14,
                    ProductModelId = 9,
                    Name = "LL Road Frame - Black, 48",
                    ProductNumber = "FR-R38B-48",
                    Color = "Black",
                    ListPrice = 337.22,
                    Size = "48",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 13181
                },
                new Product
                {
                    Id = 738,
                    ProductSubcategoryId = 14,
                    ProductModelId = 9,
                    Name = "LL Road Frame - Black, 52",
                    ProductNumber = "FR-R38B-52",
                    Color = "Black",
                    ListPrice = 337.22,
                    Size = "52",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 14642
                },
                new Product
                {
                    Id = 739,
                    ProductSubcategoryId = 12,
                    ProductModelId = 5,
                    Name = "HL Mountain Frame - Silver, 42",
                    ProductNumber = "FR-M94S-42",
                    Color = "Silver",
                    ListPrice = 1364.5,
                    Size = "42",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 26330
                },
                new Product
                {
                    Id = 740,
                    ProductSubcategoryId = 12,
                    ProductModelId = 5,
                    Name = "HL Mountain Frame - Silver, 44",
                    ProductNumber = "FR-M94S-44",
                    Color = "Silver",
                    ListPrice = 1364.5,
                    Size = "44",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 27791
                },
                new Product
                {
                    Id = 741,
                    ProductSubcategoryId = 12,
                    ProductModelId = 5,
                    Name = "HL Mountain Frame - Silver, 48",
                    ProductNumber = "FR-M94S-52",
                    Color = "Silver",
                    ListPrice = 1364.5,
                    Size = "48",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 29252
                },
                new Product
                {
                    Id = 742,
                    ProductSubcategoryId = 12,
                    ProductModelId = 5,
                    Name = "HL Mountain Frame - Silver, 46",
                    ProductNumber = "FR-M94S-46",
                    Color = "Silver",
                    ListPrice = 1364.5,
                    Size = "46",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 30713
                },
                new Product
                {
                    Id = 743,
                    ProductSubcategoryId = 12,
                    ProductModelId = 5,
                    Name = "HL Mountain Frame - Black, 42",
                    ProductNumber = "FR-M94B-42",
                    Color = "Black",
                    ListPrice = 1349.6,
                    Size = "42",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 26330
                },
                new Product
                {
                    Id = 744,
                    ProductSubcategoryId = 12,
                    ProductModelId = 5,
                    Name = "HL Mountain Frame - Black, 44",
                    ProductNumber = "FR-M94B-44",
                    Color = "Black",
                    ListPrice = 1349.6,
                    Size = "44",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 27791
                },
                new Product
                {
                    Id = 745,
                    ProductSubcategoryId = 12,
                    ProductModelId = 5,
                    Name = "HL Mountain Frame - Black, 48",
                    ProductNumber = "FR-M94B-48",
                    Color = "Black",
                    ListPrice = 1349.6,
                    Size = "48",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 29252
                },
                new Product
                {
                    Id = 746,
                    ProductSubcategoryId = 12,
                    ProductModelId = 5,
                    Name = "HL Mountain Frame - Black, 46",
                    ProductNumber = "FR-M94B-46",
                    Color = "Black",
                    ListPrice = 1349.6,
                    Size = "46",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 30713
                },
                new Product
                {
                    Id = 747,
                    ProductSubcategoryId = 12,
                    ProductModelId = 5,
                    Name = "HL Mountain Frame - Black, 38",
                    ProductNumber = "FR-M94B-38",
                    Color = "Black",
                    ListPrice = 1349.6,
                    Size = "38",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 24869
                },
                new Product
                {
                    Id = 748,
                    ProductSubcategoryId = 12,
                    ProductModelId = 5,
                    Name = "HL Mountain Frame - Silver, 38",
                    ProductNumber = "FR-M94S-38",
                    Color = "Silver",
                    ListPrice = 1364.5,
                    Size = "38",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 24869
                },
                new Product
                {
                    Id = 749,
                    ProductSubcategoryId = 2,
                    ProductModelId = 25,
                    Name = "Road-150 Red, 62",
                    ProductNumber = "BK-R93R-62",
                    Color = "Red",
                    ListPrice = 3578.27,
                    Size = "62",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 15.00
                },
                new Product
                {
                    Id = 750,
                    ProductSubcategoryId = 2,
                    ProductModelId = 25,
                    Name = "Road-150 Red, 44",
                    ProductNumber = "BK-R93R-44",
                    Color = "Red",
                    ListPrice = 3578.27,
                    Size = "44",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 13.77
                },
                new Product
                {
                    Id = 751,
                    ProductSubcategoryId = 2,
                    ProductModelId = 25,
                    Name = "Road-150 Red, 48",
                    ProductNumber = "BK-R93R-48",
                    Color = "Red",
                    ListPrice = 3578.27,
                    Size = "48",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 14.13
                },
                new Product
                {
                    Id = 752,
                    ProductSubcategoryId = 2,
                    ProductModelId = 25,
                    Name = "Road-150 Red, 52",
                    ProductNumber = "BK-R93R-52",
                    Color = "Red",
                    ListPrice = 3578.27,
                    Size = "52",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 14.42
                },
                new Product
                {
                    Id = 753,
                    ProductSubcategoryId = 2,
                    ProductModelId = 25,
                    Name = "Road-150 Red, 56",
                    ProductNumber = "BK-R93R-56",
                    Color = "Red",
                    ListPrice = 3578.27,
                    Size = "56",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 14.68
                },
                new Product
                {
                    Id = 754,
                    ProductSubcategoryId = 2,
                    ProductModelId = 28,
                    Name = "Road-450 Red, 58",
                    ProductNumber = "BK-R68R-58",
                    Color = "Red",
                    ListPrice = 1457.99,
                    Size = "58",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 17.79
                },
                new Product
                {
                    Id = 755,
                    ProductSubcategoryId = 2,
                    ProductModelId = 28,
                    Name = "Road-450 Red, 60",
                    ProductNumber = "BK-R68R-60",
                    Color = "Red",
                    ListPrice = 1457.99,
                    Size = "60",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 17.90
                },
                new Product
                {
                    Id = 756,
                    ProductSubcategoryId = 2,
                    ProductModelId = 28,
                    Name = "Road-450 Red, 44",
                    ProductNumber = "BK-R68R-44",
                    Color = "Red",
                    ListPrice = 1457.99,
                    Size = "44",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 16.77
                },
                new Product
                {
                    Id = 757,
                    ProductSubcategoryId = 2,
                    ProductModelId = 28,
                    Name = "Road-450 Red, 48",
                    ProductNumber = "BK-R68R-48",
                    Color = "Red",
                    ListPrice = 1457.99,
                    Size = "48",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 17.13
                },
                new Product
                {
                    Id = 758,
                    ProductSubcategoryId = 2,
                    ProductModelId = 28,
                    Name = "Road-450 Red, 52",
                    ProductNumber = "BK-R68R-52",
                    Color = "Red",
                    ListPrice = 1457.99,
                    Size = "52",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 17.42
                },
                new Product
                {
                    Id = 759,
                    ProductSubcategoryId = 2,
                    ProductModelId = 30,
                    Name = "Road-650 Red, 58",
                    ProductNumber = "BK-R50R-58",
                    Color = "Red",
                    ListPrice = 782.99,
                    Size = "58",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 19.79
                },
                new Product
                {
                    Id = 760,
                    ProductSubcategoryId = 2,
                    ProductModelId = 30,
                    Name = "Road-650 Red, 60",
                    ProductNumber = "BK-R50R-60",
                    Color = "Red",
                    ListPrice = 782.99,
                    Size = "60",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 19.90
                },
                new Product
                {
                    Id = 761,
                    ProductSubcategoryId = 2,
                    ProductModelId = 30,
                    Name = "Road-650 Red, 62",
                    ProductNumber = "BK-R50R-62",
                    Color = "Red",
                    ListPrice = 782.99,
                    Size = "62",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 20.00
                },
                new Product
                {
                    Id = 762,
                    ProductSubcategoryId = 2,
                    ProductModelId = 30,
                    Name = "Road-650 Red, 44",
                    ProductNumber = "BK-R50R-44",
                    Color = "Red",
                    ListPrice = 782.99,
                    Size = "44",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 18.77
                },
                new Product
                {
                    Id = 763,
                    ProductSubcategoryId = 2,
                    ProductModelId = 30,
                    Name = "Road-650 Red, 48",
                    ProductNumber = "BK-R50R-48",
                    Color = "Red",
                    ListPrice = 782.99,
                    Size = "48",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 19.13
                },
                new Product
                {
                    Id = 764,
                    ProductSubcategoryId = 2,
                    ProductModelId = 30,
                    Name = "Road-650 Red, 52",
                    ProductNumber = "BK-R50R-52",
                    Color = "Red",
                    ListPrice = 782.99,
                    Size = "52",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 19.42
                },
                new Product
                {
                    Id = 765,
                    ProductSubcategoryId = 2,
                    ProductModelId = 30,
                    Name = "Road-650 Black, 58",
                    ProductNumber = "BK-R50B-58",
                    Color = "Black",
                    ListPrice = 782.99,
                    Size = "58",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 19.79
                },
                new Product
                {
                    Id = 766,
                    ProductSubcategoryId = 2,
                    ProductModelId = 30,
                    Name = "Road-650 Black, 60",
                    ProductNumber = "BK-R50B-60",
                    Color = "Black",
                    ListPrice = 782.99,
                    Size = "60",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 19.90
                },
                new Product
                {
                    Id = 767,
                    ProductSubcategoryId = 2,
                    ProductModelId = 30,
                    Name = "Road-650 Black, 62",
                    ProductNumber = "BK-R50B-62",
                    Color = "Black",
                    ListPrice = 782.99,
                    Size = "62",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 20.00
                },
                new Product
                {
                    Id = 768,
                    ProductSubcategoryId = 2,
                    ProductModelId = 30,
                    Name = "Road-650 Black, 44",
                    ProductNumber = "BK-R50B-44",
                    Color = "Black",
                    ListPrice = 782.99,
                    Size = "44",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 18.77
                },
                new Product
                {
                    Id = 769,
                    ProductSubcategoryId = 2,
                    ProductModelId = 30,
                    Name = "Road-650 Black, 48",
                    ProductNumber = "BK-R50B-48",
                    Color = "Black",
                    ListPrice = 782.99,
                    Size = "48",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 19.13
                },
                new Product
                {
                    Id = 770,
                    ProductSubcategoryId = 2,
                    ProductModelId = 30,
                    Name = "Road-650 Black, 52",
                    ProductNumber = "BK-R50B-52",
                    Color = "Black",
                    ListPrice = 782.99,
                    Size = "52",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 19.42
                },
                new Product
                {
                    Id = 771,
                    ProductSubcategoryId = 1,
                    ProductModelId = 19,
                    Name = "Mountain-100 Silver, 38",
                    ProductNumber = "BK-M82S-38",
                    Color = "Silver",
                    ListPrice = 3399.99,
                    Size = "38",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 20.35
                },
                new Product
                {
                    Id = 772,
                    ProductSubcategoryId = 1,
                    ProductModelId = 19,
                    Name = "Mountain-100 Silver, 42",
                    ProductNumber = "BK-M82S-42",
                    Color = "Silver",
                    ListPrice = 3399.99,
                    Size = "42",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 20.77
                },
                new Product
                {
                    Id = 773,
                    ProductSubcategoryId = 1,
                    ProductModelId = 19,
                    Name = "Mountain-100 Silver, 44",
                    ProductNumber = "BK-M82S-44",
                    Color = "Silver",
                    ListPrice = 3399.99,
                    Size = "44",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 21.13
                },
                new Product
                {
                    Id = 774,
                    ProductSubcategoryId = 1,
                    ProductModelId = 19,
                    Name = "Mountain-100 Silver, 48",
                    ProductNumber = "BK-M82S-48",
                    Color = "Silver",
                    ListPrice = 3399.99,
                    Size = "48",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 21.42
                },
                new Product
                {
                    Id = 775,
                    ProductSubcategoryId = 1,
                    ProductModelId = 19,
                    Name = "Mountain-100 Black, 38",
                    ProductNumber = "BK-M82B-38",
                    Color = "Black",
                    ListPrice = 3374.99,
                    Size = "38",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 20.35
                },
                new Product
                {
                    Id = 776,
                    ProductSubcategoryId = 1,
                    ProductModelId = 19,
                    Name = "Mountain-100 Black, 42",
                    ProductNumber = "BK-M82B-42",
                    Color = "Black",
                    ListPrice = 3374.99,
                    Size = "42",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 20.77
                },
                new Product
                {
                    Id = 777,
                    ProductSubcategoryId = 1,
                    ProductModelId = 19,
                    Name = "Mountain-100 Black, 44",
                    ProductNumber = "BK-M82B-44",
                    Color = "Black",
                    ListPrice = 3374.99,
                    Size = "44",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 21.13
                },
                new Product
                {
                    Id = 778,
                    ProductSubcategoryId = 1,
                    ProductModelId = 19,
                    Name = "Mountain-100 Black, 48",
                    ProductNumber = "BK-M82B-48",
                    Color = "Black",
                    ListPrice = 3374.99,
                    Size = "48",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 21.42
                },
                new Product
                {
                    Id = 779,
                    ProductSubcategoryId = 1,
                    ProductModelId = 20,
                    Name = "Mountain-200 Silver, 38",
                    ProductNumber = "BK-M68S-38",
                    Color = "Silver",
                    ListPrice = 2319.99,
                    Size = "38",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 23.35
                },
                new Product
                {
                    Id = 780,
                    ProductSubcategoryId = 1,
                    ProductModelId = 20,
                    Name = "Mountain-200 Silver, 42",
                    ProductNumber = "BK-M68S-42",
                    Color = "Silver",
                    ListPrice = 2319.99,
                    Size = "42",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 23.77
                },
                new Product
                {
                    Id = 781,
                    ProductSubcategoryId = 1,
                    ProductModelId = 20,
                    Name = "Mountain-200 Silver, 46",
                    ProductNumber = "BK-M68S-46",
                    Color = "Silver",
                    ListPrice = 2319.99,
                    Size = "46",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 24.13
                },
                new Product
                {
                    Id = 782,
                    ProductSubcategoryId = 1,
                    ProductModelId = 20,
                    Name = "Mountain-200 Black, 38",
                    ProductNumber = "BK-M68B-38",
                    Color = "Black",
                    ListPrice = 2294.99,
                    Size = "38",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 23.35
                },
                new Product
                {
                    Id = 783,
                    ProductSubcategoryId = 1,
                    ProductModelId = 20,
                    Name = "Mountain-200 Black, 42",
                    ProductNumber = "BK-M68B-42",
                    Color = "Black",
                    ListPrice = 2294.99,
                    Size = "42",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 23.77
                },
                new Product
                {
                    Id = 784,
                    ProductSubcategoryId = 1,
                    ProductModelId = 20,
                    Name = "Mountain-200 Black, 46",
                    ProductNumber = "BK-M68B-46",
                    Color = "Black",
                    ListPrice = 2294.99,
                    Size = "46",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 24.13
                },
                new Product
                {
                    Id = 785,
                    ProductSubcategoryId = 1,
                    ProductModelId = 21,
                    Name = "Mountain-300 Black, 38",
                    ProductNumber = "BK-M47B-38",
                    Color = "Black",
                    ListPrice = 1079.99,
                    Size = "38",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 25.35
                },
                new Product
                {
                    Id = 786,
                    ProductSubcategoryId = 1,
                    ProductModelId = 21,
                    Name = "Mountain-300 Black, 40",
                    ProductNumber = "BK-M47B-40",
                    Color = "Black",
                    ListPrice = 1079.99,
                    Size = "40",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 25.77
                },
                new Product
                {
                    Id = 787,
                    ProductSubcategoryId = 1,
                    ProductModelId = 21,
                    Name = "Mountain-300 Black, 44",
                    ProductNumber = "BK-M47B-44",
                    Color = "Black",
                    ListPrice = 1079.99,
                    Size = "44",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 26.13
                },
                new Product
                {
                    Id = 788,
                    ProductSubcategoryId = 1,
                    ProductModelId = 21,
                    Name = "Mountain-300 Black, 48",
                    ProductNumber = "BK-M47B-48",
                    Color = "Black",
                    ListPrice = 1079.99,
                    Size = "48",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 26.42
                },
                new Product
                {
                    Id = 789,
                    ProductSubcategoryId = 2,
                    ProductModelId = 26,
                    Name = "Road-250 Red, 44",
                    ProductNumber = "BK-R89R-44",
                    Color = "Red",
                    ListPrice = 2443.35,
                    Size = "44",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 14.77
                },
                new Product
                {
                    Id = 790,
                    ProductSubcategoryId = 2,
                    ProductModelId = 26,
                    Name = "Road-250 Red, 48",
                    ProductNumber = "BK-R89R-48",
                    Color = "Red",
                    ListPrice = 2443.35,
                    Size = "48",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 15.13
                },
                new Product
                {
                    Id = 791,
                    ProductSubcategoryId = 2,
                    ProductModelId = 26,
                    Name = "Road-250 Red, 52",
                    ProductNumber = "BK-R89R-52",
                    Color = "Red",
                    ListPrice = 2443.35,
                    Size = "52",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 15.42
                },
                new Product
                {
                    Id = 792,
                    ProductSubcategoryId = 2,
                    ProductModelId = 26,
                    Name = "Road-250 Red, 58",
                    ProductNumber = "BK-R89R-58",
                    Color = "Red",
                    ListPrice = 2443.35,
                    Size = "58",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 15.79
                },
                new Product
                {
                    Id = 793,
                    ProductSubcategoryId = 2,
                    ProductModelId = 26,
                    Name = "Road-250 Black, 44",
                    ProductNumber = "BK-R89B-44",
                    Color = "Black",
                    ListPrice = 2443.35,
                    Size = "44",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 14.77
                },
                new Product
                {
                    Id = 794,
                    ProductSubcategoryId = 2,
                    ProductModelId = 26,
                    Name = "Road-250 Black, 48",
                    ProductNumber = "BK-R89B-48",
                    Color = "Black",
                    ListPrice = 2443.35,
                    Size = "48",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 15.13
                },
                new Product
                {
                    Id = 795,
                    ProductSubcategoryId = 2,
                    ProductModelId = 26,
                    Name = "Road-250 Black, 52",
                    ProductNumber = "BK-R89B-52",
                    Color = "Black",
                    ListPrice = 2443.35,
                    Size = "52",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 15.42
                },
                new Product
                {
                    Id = 796,
                    ProductSubcategoryId = 2,
                    ProductModelId = 26,
                    Name = "Road-250 Black, 58",
                    ProductNumber = "BK-R89B-58",
                    Color = "Black",
                    ListPrice = 2443.35,
                    Size = "58",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 15.68
                },
                new Product
                {
                    Id = 797,
                    ProductSubcategoryId = 2,
                    ProductModelId = 29,
                    Name = "Road-550-W Yellow, 38",
                    ProductNumber = "BK-R64Y-38",
                    Color = "Yellow",
                    ListPrice = 1120.49,
                    Size = "38",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 17.35
                },
                new Product
                {
                    Id = 798,
                    ProductSubcategoryId = 2,
                    ProductModelId = 29,
                    Name = "Road-550-W Yellow, 40",
                    ProductNumber = "BK-R64Y-40",
                    Color = "Yellow",
                    ListPrice = 1120.49,
                    Size = "40",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 17.77
                },
                new Product
                {
                    Id = 799,
                    ProductSubcategoryId = 2,
                    ProductModelId = 29,
                    Name = "Road-550-W Yellow, 42",
                    ProductNumber = "BK-R64Y-42",
                    Color = "Yellow",
                    ListPrice = 1120.49,
                    Size = "42",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 18.13
                },
                new Product
                {
                    Id = 800,
                    ProductSubcategoryId = 2,
                    ProductModelId = 29,
                    Name = "Road-550-W Yellow, 44",
                    ProductNumber = "BK-R64Y-44",
                    Color = "Yellow",
                    ListPrice = 1120.49,
                    Size = "44",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 18.42
                },
                new Product
                {
                    Id = 801,
                    ProductSubcategoryId = 2,
                    ProductModelId = 29,
                    Name = "Road-550-W Yellow, 48",
                    ProductNumber = "BK-R64Y-48",
                    Color = "Yellow",
                    ListPrice = 1120.49,
                    Size = "48",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 18.68
                },
                new Product
                {
                    Id = 802,
                    ProductSubcategoryId = 10,
                    ProductModelId = 104,
                    Name = "LL Fork",
                    ProductNumber = "FK-1639",
                    Color = null,
                    ListPrice = 148.22,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 803,
                    ProductSubcategoryId = 10,
                    ProductModelId = 105,
                    Name = "ML Fork",
                    ProductNumber = "FK-5136",
                    Color = null,
                    ListPrice = 175.49,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 804,
                    ProductSubcategoryId = 10,
                    ProductModelId = 106,
                    Name = "HL Fork",
                    ProductNumber = "FK-9939",
                    Color = null,
                    ListPrice = 229.49,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 805,
                    ProductSubcategoryId = 11,
                    ProductModelId = 59,
                    Name = "LL Headset",
                    ProductNumber = "HS-0296",
                    Color = null,
                    ListPrice = 34.2,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 806,
                    ProductSubcategoryId = 11,
                    ProductModelId = 60,
                    Name = "ML Headset",
                    ProductNumber = "HS-2451",
                    Color = null,
                    ListPrice = 102.29,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 807,
                    ProductSubcategoryId = 11,
                    ProductModelId = 61,
                    Name = "HL Headset",
                    ProductNumber = "HS-3479",
                    Color = null,
                    ListPrice = 124.73,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 808,
                    ProductSubcategoryId = 4,
                    ProductModelId = 52,
                    Name = "LL Mountain Handlebars",
                    ProductNumber = "HB-M243",
                    Color = null,
                    ListPrice = 44.54,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 809,
                    ProductSubcategoryId = 4,
                    ProductModelId = 54,
                    Name = "ML Mountain Handlebars",
                    ProductNumber = "HB-M763",
                    Color = null,
                    ListPrice = 61.92,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 810,
                    ProductSubcategoryId = 4,
                    ProductModelId = 55,
                    Name = "HL Mountain Handlebars",
                    ProductNumber = "HB-M918",
                    Color = null,
                    ListPrice = 120.27,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 811,
                    ProductSubcategoryId = 4,
                    ProductModelId = 56,
                    Name = "LL Road Handlebars",
                    ProductNumber = "HB-R504",
                    Color = null,
                    ListPrice = 44.54,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 812,
                    ProductSubcategoryId = 4,
                    ProductModelId = 57,
                    Name = "ML Road Handlebars",
                    ProductNumber = "HB-R720",
                    Color = null,
                    ListPrice = 61.92,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 813,
                    ProductSubcategoryId = 4,
                    ProductModelId = 58,
                    Name = "HL Road Handlebars",
                    ProductNumber = "HB-R956",
                    Color = null,
                    ListPrice = 120.27,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 814,
                    ProductSubcategoryId = 12,
                    ProductModelId = 15,
                    Name = "ML Mountain Frame - Black, 38",
                    ProductNumber = "FR-M63B-38",
                    Color = "Black",
                    ListPrice = 348.76,
                    Size = "38",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 26696
                },
                new Product
                {
                    Id = 815,
                    ProductSubcategoryId = 17,
                    ProductModelId = 42,
                    Name = "LL Mountain Front Wheel",
                    ProductNumber = "FW-M423",
                    Color = "Black",
                    ListPrice = 60.745,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 816,
                    ProductSubcategoryId = 17,
                    ProductModelId = 45,
                    Name = "ML Mountain Front Wheel",
                    ProductNumber = "FW-M762",
                    Color = "Black",
                    ListPrice = 209.025,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 817,
                    ProductSubcategoryId = 17,
                    ProductModelId = 46,
                    Name = "HL Mountain Front Wheel",
                    ProductNumber = "FW-M928",
                    Color = "Black",
                    ListPrice = 300.215,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 818,
                    ProductSubcategoryId = 17,
                    ProductModelId = 49,
                    Name = "LL Road Front Wheel",
                    ProductNumber = "FW-R623",
                    Color = "Black",
                    ListPrice = 85.565,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = "G  ",
                    Weight = 900.00
                },
                new Product
                {
                    Id = 819,
                    ProductSubcategoryId = 17,
                    ProductModelId = 50,
                    Name = "ML Road Front Wheel",
                    ProductNumber = "FW-R762",
                    Color = "Black",
                    ListPrice = 248.385,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = "G  ",
                    Weight = 850.00
                },
                new Product
                {
                    Id = 820,
                    ProductSubcategoryId = 17,
                    ProductModelId = 51,
                    Name = "HL Road Front Wheel",
                    ProductNumber = "FW-R820",
                    Color = "Black",
                    ListPrice = 330.06,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = "G  ",
                    Weight = 650.00
                },
                new Product
                {
                    Id = 821,
                    ProductSubcategoryId = 17,
                    ProductModelId = 44,
                    Name = "Touring Front Wheel",
                    ProductNumber = "FW-T905",
                    Color = "Black",
                    ListPrice = 218.01,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 822,
                    ProductSubcategoryId = 14,
                    ProductModelId = 17,
                    Name = "ML Road Frame-W - Yellow, 38",
                    ProductNumber = "FR-R72Y-38",
                    Color = "Yellow",
                    ListPrice = 594.83,
                    Size = "38",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 43132
                },
                new Product
                {
                    Id = 823,
                    ProductSubcategoryId = 17,
                    ProductModelId = 123,
                    Name = "LL Mountain Rear Wheel",
                    ProductNumber = "RW-M423",
                    Color = "Black",
                    ListPrice = 87.745,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 824,
                    ProductSubcategoryId = 17,
                    ProductModelId = 124,
                    Name = "ML Mountain Rear Wheel",
                    ProductNumber = "RW-M762",
                    Color = "Black",
                    ListPrice = 236.025,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 825,
                    ProductSubcategoryId = 17,
                    ProductModelId = 125,
                    Name = "HL Mountain Rear Wheel",
                    ProductNumber = "RW-M928",
                    Color = "Black",
                    ListPrice = 327.215,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 826,
                    ProductSubcategoryId = 17,
                    ProductModelId = 126,
                    Name = "LL Road Rear Wheel",
                    ProductNumber = "RW-R623",
                    Color = "Black",
                    ListPrice = 112.565,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = "G  ",
                    Weight = 1050.00
                },
                new Product
                {
                    Id = 827,
                    ProductSubcategoryId = 17,
                    ProductModelId = 77,
                    Name = "ML Road Rear Wheel",
                    ProductNumber = "RW-R762",
                    Color = "Black",
                    ListPrice = 275.385,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = "G  ",
                    Weight = 1000.00
                },
                new Product
                {
                    Id = 828,
                    ProductSubcategoryId = 17,
                    ProductModelId = 78,
                    Name = "HL Road Rear Wheel",
                    ProductNumber = "RW-R820",
                    Color = "Black",
                    ListPrice = 357.06,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = "G  ",
                    Weight = 890.00
                },
                new Product
                {
                    Id = 829,
                    ProductSubcategoryId = 17,
                    ProductModelId = 43,
                    Name = "Touring Rear Wheel",
                    ProductNumber = "RW-T905",
                    Color = "Black",
                    ListPrice = 245.01,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 830,
                    ProductSubcategoryId = 12,
                    ProductModelId = 14,
                    Name = "ML Mountain Frame - Black, 40",
                    ProductNumber = "FR-M63B-40",
                    Color = "Black",
                    ListPrice = 348.76,
                    Size = "40",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 28157
                },
                new Product
                {
                    Id = 831,
                    ProductSubcategoryId = 12,
                    ProductModelId = 14,
                    Name = "ML Mountain Frame - Black, 44",
                    ProductNumber = "FR-M63B-44",
                    Color = "Black",
                    ListPrice = 348.76,
                    Size = "44",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 29618
                },
                new Product
                {
                    Id = 832,
                    ProductSubcategoryId = 12,
                    ProductModelId = 14,
                    Name = "ML Mountain Frame - Black, 48",
                    ProductNumber = "FR-M63B-48",
                    Color = "Black",
                    ListPrice = 348.76,
                    Size = "48",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 31079
                },
                new Product
                {
                    Id = 833,
                    ProductSubcategoryId = 14,
                    ProductModelId = 17,
                    Name = "ML Road Frame-W - Yellow, 40",
                    ProductNumber = "FR-R72Y-40",
                    Color = "Yellow",
                    ListPrice = 594.83,
                    Size = "40",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 44593
                },
                new Product
                {
                    Id = 834,
                    ProductSubcategoryId = 14,
                    ProductModelId = 17,
                    Name = "ML Road Frame-W - Yellow, 42",
                    ProductNumber = "FR-R72Y-42",
                    Color = "Yellow",
                    ListPrice = 594.83,
                    Size = "42",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 46054
                },
                new Product
                {
                    Id = 835,
                    ProductSubcategoryId = 14,
                    ProductModelId = 17,
                    Name = "ML Road Frame-W - Yellow, 44",
                    ProductNumber = "FR-R72Y-44",
                    Color = "Yellow",
                    ListPrice = 594.83,
                    Size = "44",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 10990
                },
                new Product
                {
                    Id = 836,
                    ProductSubcategoryId = 14,
                    ProductModelId = 17,
                    Name = "ML Road Frame-W - Yellow, 48",
                    ProductNumber = "FR-R72Y-48",
                    Color = "Yellow",
                    ListPrice = 594.83,
                    Size = "48",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 12451
                },
                new Product
                {
                    Id = 837,
                    ProductSubcategoryId = 14,
                    ProductModelId = 6,
                    Name = "HL Road Frame - Black, 62",
                    ProductNumber = "FR-R92B-62",
                    Color = "Black",
                    ListPrice = 1431.5,
                    Size = "62",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 10990
                },
                new Product
                {
                    Id = 838,
                    ProductSubcategoryId = 14,
                    ProductModelId = 6,
                    Name = "HL Road Frame - Black, 44",
                    ProductNumber = "FR-R92B-44",
                    Color = "Black",
                    ListPrice = 1431.5,
                    Size = "44",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 41610
                },
                new Product
                {
                    Id = 839,
                    ProductSubcategoryId = 14,
                    ProductModelId = 6,
                    Name = "HL Road Frame - Black, 48",
                    ProductNumber = "FR-R92B-48",
                    Color = "Black",
                    ListPrice = 1431.5,
                    Size = "48",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 42401
                },
                new Product
                {
                    Id = 840,
                    ProductSubcategoryId = 14,
                    ProductModelId = 6,
                    Name = "HL Road Frame - Black, 52",
                    ProductNumber = "FR-R92B-52",
                    Color = "Black",
                    ListPrice = 1431.5,
                    Size = "52",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 43862
                },
                new Product
                {
                    Id = 841,
                    ProductSubcategoryId = 22,
                    ProductModelId = 13,
                    Name = "Men's Sports Shorts, S",
                    ProductNumber = "SH-M897-S",
                    Color = "Black",
                    ListPrice = 59.99,
                    Size = "S",
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 842,
                    ProductSubcategoryId = 35,
                    ProductModelId = 120,
                    Name = "Touring-Panniers, Large",
                    ProductNumber = "PA-T100",
                    Color = "Grey",
                    ListPrice = 125,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 843,
                    ProductSubcategoryId = 34,
                    ProductModelId = 115,
                    Name = "Cable Lock",
                    ProductNumber = "LO-C100",
                    Color = null,
                    ListPrice = 25,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 844,
                    ProductSubcategoryId = 36,
                    ProductModelId = 116,
                    Name = "Minipump",
                    ProductNumber = "PU-0452",
                    Color = null,
                    ListPrice = 19.99,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 845,
                    ProductSubcategoryId = 36,
                    ProductModelId = 117,
                    Name = "Mountain Pump",
                    ProductNumber = "PU-M044",
                    Color = null,
                    ListPrice = 24.99,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 846,
                    ProductSubcategoryId = 33,
                    ProductModelId = 108,
                    Name = "Taillights - Battery-Powered",
                    ProductNumber = "LT-T990",
                    Color = null,
                    ListPrice = 13.99,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 847,
                    ProductSubcategoryId = 33,
                    ProductModelId = 109,
                    Name = "Headlights - Dual-Beam",
                    ProductNumber = "LT-H902",
                    Color = null,
                    ListPrice = 34.99,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 848,
                    ProductSubcategoryId = 33,
                    ProductModelId = 110,
                    Name = "Headlights - Weatherproof",
                    ProductNumber = "LT-H903",
                    Color = null,
                    ListPrice = 44.99,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 849,
                    ProductSubcategoryId = 22,
                    ProductModelId = 13,
                    Name = "Men's Sports Shorts, M",
                    ProductNumber = "SH-M897-M",
                    Color = "Black",
                    ListPrice = 59.99,
                    Size = "M",
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 850,
                    ProductSubcategoryId = 22,
                    ProductModelId = 13,
                    Name = "Men's Sports Shorts, L",
                    ProductNumber = "SH-M897-L",
                    Color = "Black",
                    ListPrice = 59.99,
                    Size = "L",
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 851,
                    ProductSubcategoryId = 22,
                    ProductModelId = 13,
                    Name = "Men's Sports Shorts, XL",
                    ProductNumber = "SH-M897-X",
                    Color = "Black",
                    ListPrice = 59.99,
                    Size = "XL",
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 852,
                    ProductSubcategoryId = 24,
                    ProductModelId = 38,
                    Name = "Women's Tights, S",
                    ProductNumber = "TG-W091-S",
                    Color = "Black",
                    ListPrice = 74.99,
                    Size = "S",
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 853,
                    ProductSubcategoryId = 24,
                    ProductModelId = 38,
                    Name = "Women's Tights, M",
                    ProductNumber = "TG-W091-M",
                    Color = "Black",
                    ListPrice = 74.99,
                    Size = "M",
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 854,
                    ProductSubcategoryId = 24,
                    ProductModelId = 38,
                    Name = "Women's Tights, L",
                    ProductNumber = "TG-W091-L",
                    Color = "Black",
                    ListPrice = 74.99,
                    Size = "L",
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 855,
                    ProductSubcategoryId = 18,
                    ProductModelId = 12,
                    Name = "Men's Bib-Shorts, S",
                    ProductNumber = "SB-M891-S",
                    Color = "Multi",
                    ListPrice = 89.99,
                    Size = "S",
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 856,
                    ProductSubcategoryId = 18,
                    ProductModelId = 12,
                    Name = "Men's Bib-Shorts, M",
                    ProductNumber = "SB-M891-M",
                    Color = "Multi",
                    ListPrice = 89.99,
                    Size = "M",
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 857,
                    ProductSubcategoryId = 18,
                    ProductModelId = 12,
                    Name = "Men's Bib-Shorts, L",
                    ProductNumber = "SB-M891-L",
                    Color = "Multi",
                    ListPrice = 89.99,
                    Size = "L",
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 858,
                    ProductSubcategoryId = 20,
                    ProductModelId = 4,
                    Name = "Half-Finger Gloves, S",
                    ProductNumber = "GL-H102-S",
                    Color = "Black",
                    ListPrice = 24.49,
                    Size = "S",
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 859,
                    ProductSubcategoryId = 20,
                    ProductModelId = 4,
                    Name = "Half-Finger Gloves, M",
                    ProductNumber = "GL-H102-M",
                    Color = "Black",
                    ListPrice = 24.49,
                    Size = "M",
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 860,
                    ProductSubcategoryId = 20,
                    ProductModelId = 4,
                    Name = "Half-Finger Gloves, L",
                    ProductNumber = "GL-H102-L",
                    Color = "Black",
                    ListPrice = 24.49,
                    Size = "L",
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 861,
                    ProductSubcategoryId = 20,
                    ProductModelId = 3,
                    Name = "Full-Finger Gloves, S",
                    ProductNumber = "GL-F110-S",
                    Color = "Black",
                    ListPrice = 37.99,
                    Size = "S",
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 862,
                    ProductSubcategoryId = 20,
                    ProductModelId = 3,
                    Name = "Full-Finger Gloves, M",
                    ProductNumber = "GL-F110-M",
                    Color = "Black",
                    ListPrice = 37.99,
                    Size = "M",
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 863,
                    ProductSubcategoryId = 20,
                    ProductModelId = 3,
                    Name = "Full-Finger Gloves, L",
                    ProductNumber = "GL-F110-L",
                    Color = "Black",
                    ListPrice = 37.99,
                    Size = "L",
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 864,
                    ProductSubcategoryId = 25,
                    ProductModelId = 1,
                    Name = "Classic Vest, S",
                    ProductNumber = "VE-C304-S",
                    Color = "Blue",
                    ListPrice = 63.5,
                    Size = "S",
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 865,
                    ProductSubcategoryId = 25,
                    ProductModelId = 1,
                    Name = "Classic Vest, M",
                    ProductNumber = "VE-C304-M",
                    Color = "Blue",
                    ListPrice = 63.5,
                    Size = "M",
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 866,
                    ProductSubcategoryId = 25,
                    ProductModelId = 1,
                    Name = "Classic Vest, L",
                    ProductNumber = "VE-C304-L",
                    Color = "Blue",
                    ListPrice = 63.5,
                    Size = "L",
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 867,
                    ProductSubcategoryId = 22,
                    ProductModelId = 37,
                    Name = "Women's Mountain Shorts, S",
                    ProductNumber = "SH-W890-S",
                    Color = "Black",
                    ListPrice = 69.99,
                    Size = "S",
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 868,
                    ProductSubcategoryId = 22,
                    ProductModelId = 37,
                    Name = "Women's Mountain Shorts, M",
                    ProductNumber = "SH-W890-M",
                    Color = "Black",
                    ListPrice = 69.99,
                    Size = "M",
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 869,
                    ProductSubcategoryId = 22,
                    ProductModelId = 37,
                    Name = "Women's Mountain Shorts, L",
                    ProductNumber = "SH-W890-L",
                    Color = "Black",
                    ListPrice = 69.99,
                    Size = "L",
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 870,
                    ProductSubcategoryId = 28,
                    ProductModelId = 111,
                    Name = "Water Bottle - 30 oz.",
                    ProductNumber = "WB-H098",
                    Color = null,
                    ListPrice = 4.99,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 871,
                    ProductSubcategoryId = 28,
                    ProductModelId = 112,
                    Name = "Mountain Bottle Cage",
                    ProductNumber = "BC-M005",
                    Color = null,
                    ListPrice = 9.99,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 872,
                    ProductSubcategoryId = 28,
                    ProductModelId = 113,
                    Name = "Road Bottle Cage",
                    ProductNumber = "BC-R205",
                    Color = null,
                    ListPrice = 8.99,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 873,
                    ProductSubcategoryId = 37,
                    ProductModelId = 114,
                    Name = "Patch Kit/8 Patches",
                    ProductNumber = "PK-7098",
                    Color = null,
                    ListPrice = 2.29,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 874,
                    ProductSubcategoryId = 23,
                    ProductModelId = 24,
                    Name = "Racing Socks, M",
                    ProductNumber = "SO-R809-M",
                    Color = "White",
                    ListPrice = 8.99,
                    Size = "M",
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 875,
                    ProductSubcategoryId = 23,
                    ProductModelId = 24,
                    Name = "Racing Socks, L",
                    ProductNumber = "SO-R809-L",
                    Color = "White",
                    ListPrice = 8.99,
                    Size = "L",
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 876,
                    ProductSubcategoryId = 26,
                    ProductModelId = 118,
                    Name = "Hitch Rack - 4-Bike",
                    ProductNumber = "RA-H123",
                    Color = null,
                    ListPrice = 120,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 877,
                    ProductSubcategoryId = 29,
                    ProductModelId = 119,
                    Name = "Bike Wash - Dissolver",
                    ProductNumber = "CL-9009",
                    Color = null,
                    ListPrice = 7.95,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 878,
                    ProductSubcategoryId = 30,
                    ProductModelId = 121,
                    Name = "Fender Set - Mountain",
                    ProductNumber = "FE-6654",
                    Color = null,
                    ListPrice = 21.98,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 879,
                    ProductSubcategoryId = 27,
                    ProductModelId = 122,
                    Name = "All-Purpose Bike Stand",
                    ProductNumber = "ST-1401",
                    Color = null,
                    ListPrice = 159,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 880,
                    ProductSubcategoryId = 32,
                    ProductModelId = 107,
                    Name = "Hydration Pack - 70 oz.",
                    ProductNumber = "HY-1023-70",
                    Color = "Silver",
                    ListPrice = 54.99,
                    Size = "70",
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 881,
                    ProductSubcategoryId = 21,
                    ProductModelId = 32,
                    Name = "Short-Sleeve Classic Jersey, S",
                    ProductNumber = "SJ-0194-S",
                    Color = "Yellow",
                    ListPrice = 53.99,
                    Size = "S",
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 882,
                    ProductSubcategoryId = 21,
                    ProductModelId = 32,
                    Name = "Short-Sleeve Classic Jersey, M",
                    ProductNumber = "SJ-0194-M",
                    Color = "Yellow",
                    ListPrice = 53.99,
                    Size = "M",
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 883,
                    ProductSubcategoryId = 21,
                    ProductModelId = 32,
                    Name = "Short-Sleeve Classic Jersey, L",
                    ProductNumber = "SJ-0194-L",
                    Color = "Yellow",
                    ListPrice = 53.99,
                    Size = "L",
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 884,
                    ProductSubcategoryId = 21,
                    ProductModelId = 32,
                    Name = "Short-Sleeve Classic Jersey, XL",
                    ProductNumber = "SJ-0194-X",
                    Color = "Yellow",
                    ListPrice = 53.99,
                    Size = "XL",
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 885,
                    ProductSubcategoryId = 16,
                    ProductModelId = 7,
                    Name = "HL Touring Frame - Yellow, 60",
                    ProductNumber = "FR-T98Y-60",
                    Color = "Yellow",
                    ListPrice = 1003.91,
                    Size = "60",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 41489
                },
                new Product
                {
                    Id = 886,
                    ProductSubcategoryId = 16,
                    ProductModelId = 10,
                    Name = "LL Touring Frame - Yellow, 62",
                    ProductNumber = "FR-T67Y-62",
                    Color = "Yellow",
                    ListPrice = 333.42,
                    Size = "62",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 43891
                },
                new Product
                {
                    Id = 887,
                    ProductSubcategoryId = 16,
                    ProductModelId = 7,
                    Name = "HL Touring Frame - Yellow, 46",
                    ProductNumber = "FR-T98Y-46",
                    Color = "Yellow",
                    ListPrice = 1003.91,
                    Size = "46",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 35096
                },
                new Product
                {
                    Id = 888,
                    ProductSubcategoryId = 16,
                    ProductModelId = 7,
                    Name = "HL Touring Frame - Yellow, 50",
                    ProductNumber = "FR-T98Y-50",
                    Color = "Yellow",
                    ListPrice = 1003.91,
                    Size = "50",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 3.00
                },
                new Product
                {
                    Id = 889,
                    ProductSubcategoryId = 16,
                    ProductModelId = 7,
                    Name = "HL Touring Frame - Yellow, 54",
                    ProductNumber = "FR-T98Y-54",
                    Color = "Yellow",
                    ListPrice = 1003.91,
                    Size = "54",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 41367
                },
                new Product
                {
                    Id = 890,
                    ProductSubcategoryId = 16,
                    ProductModelId = 7,
                    Name = "HL Touring Frame - Blue, 46",
                    ProductNumber = "FR-T98U-46",
                    Color = "Blue",
                    ListPrice = 1003.91,
                    Size = "46",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 35096
                },
                new Product
                {
                    Id = 891,
                    ProductSubcategoryId = 16,
                    ProductModelId = 7,
                    Name = "HL Touring Frame - Blue, 50",
                    ProductNumber = "FR-T98U-50",
                    Color = "Blue",
                    ListPrice = 1003.91,
                    Size = "50",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 3.00
                },
                new Product
                {
                    Id = 892,
                    ProductSubcategoryId = 16,
                    ProductModelId = 7,
                    Name = "HL Touring Frame - Blue, 54",
                    ProductNumber = "FR-T98U-54",
                    Color = "Blue",
                    ListPrice = 1003.91,
                    Size = "54",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 41367
                },
                new Product
                {
                    Id = 893,
                    ProductSubcategoryId = 16,
                    ProductModelId = 7,
                    Name = "HL Touring Frame - Blue, 60",
                    ProductNumber = "FR-T98U-60",
                    Color = "Blue",
                    ListPrice = 1003.91,
                    Size = "60",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 41489
                },
                new Product
                {
                    Id = 894,
                    ProductSubcategoryId = 9,
                    ProductModelId = 127,
                    Name = "Rear Derailleur",
                    ProductNumber = "RD-2308",
                    Color = "Silver",
                    ListPrice = 121.46,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = "G  ",
                    Weight = 215.00
                },
                new Product
                {
                    Id = 895,
                    ProductSubcategoryId = 16,
                    ProductModelId = 10,
                    Name = "LL Touring Frame - Blue, 50",
                    ProductNumber = "FR-T67U-50",
                    Color = "Blue",
                    ListPrice = 333.42,
                    Size = "50",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 41550
                },
                new Product
                {
                    Id = 896,
                    ProductSubcategoryId = 16,
                    ProductModelId = 10,
                    Name = "LL Touring Frame - Blue, 54",
                    ProductNumber = "FR-T67U-54",
                    Color = "Blue",
                    ListPrice = 333.42,
                    Size = "54",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 41699
                },
                new Product
                {
                    Id = 897,
                    ProductSubcategoryId = 16,
                    ProductModelId = 10,
                    Name = "LL Touring Frame - Blue, 58",
                    ProductNumber = "FR-T67U-58",
                    Color = "Blue",
                    ListPrice = 333.42,
                    Size = "58",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 42430
                },
                new Product
                {
                    Id = 898,
                    ProductSubcategoryId = 16,
                    ProductModelId = 10,
                    Name = "LL Touring Frame - Blue, 62",
                    ProductNumber = "FR-T67U-62",
                    Color = "Blue",
                    ListPrice = 333.42,
                    Size = "62",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 43891
                },
                new Product
                {
                    Id = 899,
                    ProductSubcategoryId = 16,
                    ProductModelId = 10,
                    Name = "LL Touring Frame - Yellow, 44",
                    ProductNumber = "FR-T67Y-44",
                    Color = "Yellow",
                    ListPrice = 333.42,
                    Size = "44",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 41308
                },
                new Product
                {
                    Id = 900,
                    ProductSubcategoryId = 16,
                    ProductModelId = 10,
                    Name = "LL Touring Frame - Yellow, 50",
                    ProductNumber = "FR-T67Y-50",
                    Color = "Yellow",
                    ListPrice = 333.42,
                    Size = "50",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 41550
                },
                new Product
                {
                    Id = 901,
                    ProductSubcategoryId = 16,
                    ProductModelId = 10,
                    Name = "LL Touring Frame - Yellow, 54",
                    ProductNumber = "FR-T67Y-54",
                    Color = "Yellow",
                    ListPrice = 333.42,
                    Size = "54",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 41699
                },
                new Product
                {
                    Id = 902,
                    ProductSubcategoryId = 16,
                    ProductModelId = 10,
                    Name = "LL Touring Frame - Yellow, 58",
                    ProductNumber = "FR-T67Y-58",
                    Color = "Yellow",
                    ListPrice = 333.42,
                    Size = "58",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 42430
                },
                new Product
                {
                    Id = 903,
                    ProductSubcategoryId = 16,
                    ProductModelId = 10,
                    Name = "LL Touring Frame - Blue, 44",
                    ProductNumber = "FR-T67U-44",
                    Color = "Blue",
                    ListPrice = 333.42,
                    Size = "44",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 41308
                },
                new Product
                {
                    Id = 904,
                    ProductSubcategoryId = 12,
                    ProductModelId = 15,
                    Name = "ML Mountain Frame-W - Silver, 40",
                    ProductNumber = "FR-M63S-40",
                    Color = "Silver",
                    ListPrice = 364.09,
                    Size = "40",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 28157
                },
                new Product
                {
                    Id = 905,
                    ProductSubcategoryId = 12,
                    ProductModelId = 15,
                    Name = "ML Mountain Frame-W - Silver, 42",
                    ProductNumber = "FR-M63S-42",
                    Color = "Silver",
                    ListPrice = 364.09,
                    Size = "42",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 29618
                },
                new Product
                {
                    Id = 906,
                    ProductSubcategoryId = 12,
                    ProductModelId = 15,
                    Name = "ML Mountain Frame-W - Silver, 46",
                    ProductNumber = "FR-M63S-46",
                    Color = "Silver",
                    ListPrice = 364.09,
                    Size = "46",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 31079
                },
                new Product
                {
                    Id = 907,
                    ProductSubcategoryId = 6,
                    ProductModelId = 128,
                    Name = "Rear Brakes",
                    ProductNumber = "RB-9231",
                    Color = "Silver",
                    ListPrice = 106.5,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = "G  ",
                    Weight = 317.00
                },
                new Product
                {
                    Id = 908,
                    ProductSubcategoryId = 15,
                    ProductModelId = 79,
                    Name = "LL Mountain Seat/Saddle",
                    ProductNumber = "SE-M236",
                    Color = null,
                    ListPrice = 27.12,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 909,
                    ProductSubcategoryId = 15,
                    ProductModelId = 80,
                    Name = "ML Mountain Seat/Saddle",
                    ProductNumber = "SE-M798",
                    Color = null,
                    ListPrice = 39.14,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 910,
                    ProductSubcategoryId = 15,
                    ProductModelId = 81,
                    Name = "HL Mountain Seat/Saddle",
                    ProductNumber = "SE-M940",
                    Color = null,
                    ListPrice = 52.64,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 911,
                    ProductSubcategoryId = 15,
                    ProductModelId = 82,
                    Name = "LL Road Seat/Saddle",
                    ProductNumber = "SE-R581",
                    Color = null,
                    ListPrice = 27.12,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 912,
                    ProductSubcategoryId = 15,
                    ProductModelId = 83,
                    Name = "ML Road Seat/Saddle",
                    ProductNumber = "SE-R908",
                    Color = null,
                    ListPrice = 39.14,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 913,
                    ProductSubcategoryId = 15,
                    ProductModelId = 84,
                    Name = "HL Road Seat/Saddle",
                    ProductNumber = "SE-R995",
                    Color = null,
                    ListPrice = 52.64,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 914,
                    ProductSubcategoryId = 15,
                    ProductModelId = 66,
                    Name = "LL Touring Seat/Saddle",
                    ProductNumber = "SE-T312",
                    Color = null,
                    ListPrice = 27.12,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 915,
                    ProductSubcategoryId = 15,
                    ProductModelId = 65,
                    Name = "ML Touring Seat/Saddle",
                    ProductNumber = "SE-T762",
                    Color = null,
                    ListPrice = 39.14,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 916,
                    ProductSubcategoryId = 15,
                    ProductModelId = 67,
                    Name = "HL Touring Seat/Saddle",
                    ProductNumber = "SE-T924",
                    Color = null,
                    ListPrice = 52.64,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 917,
                    ProductSubcategoryId = 12,
                    ProductModelId = 8,
                    Name = "LL Mountain Frame - Silver, 42",
                    ProductNumber = "FR-M21S-42",
                    Color = "Silver",
                    ListPrice = 264.05,
                    Size = "42",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 33635
                },
                new Product
                {
                    Id = 918,
                    ProductSubcategoryId = 12,
                    ProductModelId = 8,
                    Name = "LL Mountain Frame - Silver, 44",
                    ProductNumber = "FR-M21S-44",
                    Color = "Silver",
                    ListPrice = 264.05,
                    Size = "44",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 35096
                },
                new Product
                {
                    Id = 919,
                    ProductSubcategoryId = 12,
                    ProductModelId = 8,
                    Name = "LL Mountain Frame - Silver, 48",
                    ProductNumber = "FR-M21S-48",
                    Color = "Silver",
                    ListPrice = 264.05,
                    Size = "48",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 3.00
                },
                new Product
                {
                    Id = 920,
                    ProductSubcategoryId = 12,
                    ProductModelId = 8,
                    Name = "LL Mountain Frame - Silver, 52",
                    ProductNumber = "FR-M21S-52",
                    Color = "Silver",
                    ListPrice = 264.05,
                    Size = "52",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 41367
                },
                new Product
                {
                    Id = 921,
                    ProductSubcategoryId = 37,
                    ProductModelId = 92,
                    Name = "Mountain Tire Tube",
                    ProductNumber = "TT-M928",
                    Color = null,
                    ListPrice = 4.99,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 922,
                    ProductSubcategoryId = 37,
                    ProductModelId = 93,
                    Name = "Road Tire Tube",
                    ProductNumber = "TT-R982",
                    Color = null,
                    ListPrice = 3.99,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 923,
                    ProductSubcategoryId = 37,
                    ProductModelId = 94,
                    Name = "Touring Tire Tube",
                    ProductNumber = "TT-T092",
                    Color = null,
                    ListPrice = 4.99,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 924,
                    ProductSubcategoryId = 12,
                    ProductModelId = 8,
                    Name = "LL Mountain Frame - Black, 42",
                    ProductNumber = "FR-M21B-42",
                    Color = "Black",
                    ListPrice = 249.79,
                    Size = "42",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 33635
                },
                new Product
                {
                    Id = 925,
                    ProductSubcategoryId = 12,
                    ProductModelId = 8,
                    Name = "LL Mountain Frame - Black, 44",
                    ProductNumber = "FR-M21B-44",
                    Color = "Black",
                    ListPrice = 249.79,
                    Size = "44",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 35096
                },
                new Product
                {
                    Id = 926,
                    ProductSubcategoryId = 12,
                    ProductModelId = 8,
                    Name = "LL Mountain Frame - Black, 48",
                    ProductNumber = "FR-M21B-48",
                    Color = "Black",
                    ListPrice = 249.79,
                    Size = "48",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 3.00
                },
                new Product
                {
                    Id = 927,
                    ProductSubcategoryId = 12,
                    ProductModelId = 8,
                    Name = "LL Mountain Frame - Black, 52",
                    ProductNumber = "FR-M21B-52",
                    Color = "Black",
                    ListPrice = 249.79,
                    Size = "52",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 41367
                },
                new Product
                {
                    Id = 928,
                    ProductSubcategoryId = 37,
                    ProductModelId = 85,
                    Name = "LL Mountain Tire",
                    ProductNumber = "TI-M267",
                    Color = null,
                    ListPrice = 24.99,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 929,
                    ProductSubcategoryId = 37,
                    ProductModelId = 86,
                    Name = "ML Mountain Tire",
                    ProductNumber = "TI-M602",
                    Color = null,
                    ListPrice = 29.99,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 930,
                    ProductSubcategoryId = 37,
                    ProductModelId = 87,
                    Name = "HL Mountain Tire",
                    ProductNumber = "TI-M823",
                    Color = null,
                    ListPrice = 35,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 931,
                    ProductSubcategoryId = 37,
                    ProductModelId = 88,
                    Name = "LL Road Tire",
                    ProductNumber = "TI-R092",
                    Color = null,
                    ListPrice = 21.49,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 932,
                    ProductSubcategoryId = 37,
                    ProductModelId = 89,
                    Name = "ML Road Tire",
                    ProductNumber = "TI-R628",
                    Color = null,
                    ListPrice = 24.99,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 933,
                    ProductSubcategoryId = 37,
                    ProductModelId = 90,
                    Name = "HL Road Tire",
                    ProductNumber = "TI-R982",
                    Color = null,
                    ListPrice = 32.6,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 934,
                    ProductSubcategoryId = 37,
                    ProductModelId = 91,
                    Name = "Touring Tire",
                    ProductNumber = "TI-T723",
                    Color = null,
                    ListPrice = 28.99,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 935,
                    ProductSubcategoryId = 13,
                    ProductModelId = 62,
                    Name = "LL Mountain Pedal",
                    ProductNumber = "PD-M282",
                    Color = "Silver/Black",
                    ListPrice = 40.49,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = "G  ",
                    Weight = 218.00
                },
                new Product
                {
                    Id = 936,
                    ProductSubcategoryId = 13,
                    ProductModelId = 63,
                    Name = "ML Mountain Pedal",
                    ProductNumber = "PD-M340",
                    Color = "Silver/Black",
                    ListPrice = 62.09,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = "G  ",
                    Weight = 215.00
                },
                new Product
                {
                    Id = 937,
                    ProductSubcategoryId = 13,
                    ProductModelId = 64,
                    Name = "HL Mountain Pedal",
                    ProductNumber = "PD-M562",
                    Color = "Silver/Black",
                    ListPrice = 80.99,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = "G  ",
                    Weight = 185.00
                },
                new Product
                {
                    Id = 938,
                    ProductSubcategoryId = 13,
                    ProductModelId = 68,
                    Name = "LL Road Pedal",
                    ProductNumber = "PD-R347",
                    Color = "Silver/Black",
                    ListPrice = 40.49,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = "G  ",
                    Weight = 189.00
                },
                new Product
                {
                    Id = 939,
                    ProductSubcategoryId = 13,
                    ProductModelId = 69,
                    Name = "ML Road Pedal",
                    ProductNumber = "PD-R563",
                    Color = "Silver/Black",
                    ListPrice = 62.09,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = "G  ",
                    Weight = 168.00
                },
                new Product
                {
                    Id = 940,
                    ProductSubcategoryId = 13,
                    ProductModelId = 70,
                    Name = "HL Road Pedal",
                    ProductNumber = "PD-R853",
                    Color = "Silver/Black",
                    ListPrice = 80.99,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = "G  ",
                    Weight = 149.00
                },
                new Product
                {
                    Id = 941,
                    ProductSubcategoryId = 13,
                    ProductModelId = 53,
                    Name = "Touring Pedal",
                    ProductNumber = "PD-T852",
                    Color = "Silver/Black",
                    ListPrice = 80.99,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 942,
                    ProductSubcategoryId = 12,
                    ProductModelId = 15,
                    Name = "ML Mountain Frame-W - Silver, 38",
                    ProductNumber = "FR-M63S-38",
                    Color = "Silver",
                    ListPrice = 364.09,
                    Size = "38",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 26696
                },
                new Product
                {
                    Id = 943,
                    ProductSubcategoryId = 12,
                    ProductModelId = 8,
                    Name = "LL Mountain Frame - Black, 40",
                    ProductNumber = "FR-M21B-40",
                    Color = "Black",
                    ListPrice = 249.79,
                    Size = "40",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 32174
                },
                new Product
                {
                    Id = 944,
                    ProductSubcategoryId = 12,
                    ProductModelId = 8,
                    Name = "LL Mountain Frame - Silver, 40",
                    ProductNumber = "FR-M21S-40",
                    Color = "Silver",
                    ListPrice = 264.05,
                    Size = "40",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 32174
                },
                new Product
                {
                    Id = 945,
                    ProductSubcategoryId = 9,
                    ProductModelId = 103,
                    Name = "Front Derailleur",
                    ProductNumber = "FD-2342",
                    Color = "Silver",
                    ListPrice = 91.49,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = "G  ",
                    Weight = 88.00
                },
                new Product
                {
                    Id = 946,
                    ProductSubcategoryId = 4,
                    ProductModelId = 47,
                    Name = "LL Touring Handlebars",
                    ProductNumber = "HB-T721",
                    Color = null,
                    ListPrice = 46.09,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 947,
                    ProductSubcategoryId = 4,
                    ProductModelId = 48,
                    Name = "HL Touring Handlebars",
                    ProductNumber = "HB-T928",
                    Color = null,
                    ListPrice = 91.57,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 948,
                    ProductSubcategoryId = 6,
                    ProductModelId = 102,
                    Name = "Front Brakes",
                    ProductNumber = "FB-9873",
                    Color = "Silver",
                    ListPrice = 106.5,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = "G  ",
                    Weight = 317.00
                },
                new Product
                {
                    Id = 949,
                    ProductSubcategoryId = 8,
                    ProductModelId = 99,
                    Name = "LL Crankset",
                    ProductNumber = "CS-4759",
                    Color = "Black",
                    ListPrice = 175.49,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = "G  ",
                    Weight = 600.00
                },
                new Product
                {
                    Id = 950,
                    ProductSubcategoryId = 8,
                    ProductModelId = 100,
                    Name = "ML Crankset",
                    ProductNumber = "CS-6583",
                    Color = "Black",
                    ListPrice = 256.49,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = "G  ",
                    Weight = 635.00
                },
                new Product
                {
                    Id = 951,
                    ProductSubcategoryId = 8,
                    ProductModelId = 101,
                    Name = "HL Crankset",
                    ProductNumber = "CS-9183",
                    Color = "Black",
                    ListPrice = 404.99,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = "G  ",
                    Weight = 575.00
                },
                new Product
                {
                    Id = 952,
                    ProductSubcategoryId = 7,
                    ProductModelId = 98,
                    Name = "Chain",
                    ProductNumber = "CH-0234",
                    Color = "Silver",
                    ListPrice = 20.24,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = null,
                    Weight = null
                },
                new Product
                {
                    Id = 953,
                    ProductSubcategoryId = 3,
                    ProductModelId = 35,
                    Name = "Touring-2000 Blue, 60",
                    ProductNumber = "BK-T44U-60",
                    Color = "Blue",
                    ListPrice = 1214.85,
                    Size = "60",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 27.90
                },
                new Product
                {
                    Id = 954,
                    ProductSubcategoryId = 3,
                    ProductModelId = 34,
                    Name = "Touring-1000 Yellow, 46",
                    ProductNumber = "BK-T79Y-46",
                    Color = "Yellow",
                    ListPrice = 2384.07,
                    Size = "46",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 25.13
                },
                new Product
                {
                    Id = 955,
                    ProductSubcategoryId = 3,
                    ProductModelId = 34,
                    Name = "Touring-1000 Yellow, 50",
                    ProductNumber = "BK-T79Y-50",
                    Color = "Yellow",
                    ListPrice = 2384.07,
                    Size = "50",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 25.42
                },
                new Product
                {
                    Id = 956,
                    ProductSubcategoryId = 3,
                    ProductModelId = 34,
                    Name = "Touring-1000 Yellow, 54",
                    ProductNumber = "BK-T79Y-54",
                    Color = "Yellow",
                    ListPrice = 2384.07,
                    Size = "54",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 25.68
                },
                new Product
                {
                    Id = 957,
                    ProductSubcategoryId = 3,
                    ProductModelId = 34,
                    Name = "Touring-1000 Yellow, 60",
                    ProductNumber = "BK-T79Y-60",
                    Color = "Yellow",
                    ListPrice = 2384.07,
                    Size = "60",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 25.90
                },
                new Product
                {
                    Id = 958,
                    ProductSubcategoryId = 3,
                    ProductModelId = 36,
                    Name = "Touring-3000 Blue, 54",
                    ProductNumber = "BK-T18U-54",
                    Color = "Blue",
                    ListPrice = 742.35,
                    Size = "54",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 29.68
                },
                new Product
                {
                    Id = 959,
                    ProductSubcategoryId = 3,
                    ProductModelId = 36,
                    Name = "Touring-3000 Blue, 58",
                    ProductNumber = "BK-T18U-58",
                    Color = "Blue",
                    ListPrice = 742.35,
                    Size = "58",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 29.90
                },
                new Product
                {
                    Id = 960,
                    ProductSubcategoryId = 3,
                    ProductModelId = 36,
                    Name = "Touring-3000 Blue, 62",
                    ProductNumber = "BK-T18U-62",
                    Color = "Blue",
                    ListPrice = 742.35,
                    Size = "62",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 30.00
                },
                new Product
                {
                    Id = 961,
                    ProductSubcategoryId = 3,
                    ProductModelId = 36,
                    Name = "Touring-3000 Yellow, 44",
                    ProductNumber = "BK-T18Y-44",
                    Color = "Yellow",
                    ListPrice = 742.35,
                    Size = "44",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 28.77
                },
                new Product
                {
                    Id = 962,
                    ProductSubcategoryId = 3,
                    ProductModelId = 36,
                    Name = "Touring-3000 Yellow, 50",
                    ProductNumber = "BK-T18Y-50",
                    Color = "Yellow",
                    ListPrice = 742.35,
                    Size = "50",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 29.13
                },
                new Product
                {
                    Id = 963,
                    ProductSubcategoryId = 3,
                    ProductModelId = 36,
                    Name = "Touring-3000 Yellow, 54",
                    ProductNumber = "BK-T18Y-54",
                    Color = "Yellow",
                    ListPrice = 742.35,
                    Size = "54",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 29.42
                },
                new Product
                {
                    Id = 964,
                    ProductSubcategoryId = 3,
                    ProductModelId = 36,
                    Name = "Touring-3000 Yellow, 58",
                    ProductNumber = "BK-T18Y-58",
                    Color = "Yellow",
                    ListPrice = 742.35,
                    Size = "58",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 29.79
                },
                new Product
                {
                    Id = 965,
                    ProductSubcategoryId = 3,
                    ProductModelId = 36,
                    Name = "Touring-3000 Yellow, 62",
                    ProductNumber = "BK-T18Y-62",
                    Color = "Yellow",
                    ListPrice = 742.35,
                    Size = "62",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 30.00
                },
                new Product
                {
                    Id = 966,
                    ProductSubcategoryId = 3,
                    ProductModelId = 34,
                    Name = "Touring-1000 Blue, 46",
                    ProductNumber = "BK-T79U-46",
                    Color = "Blue",
                    ListPrice = 2384.07,
                    Size = "46",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 25.13
                },
                new Product
                {
                    Id = 967,
                    ProductSubcategoryId = 3,
                    ProductModelId = 34,
                    Name = "Touring-1000 Blue, 50",
                    ProductNumber = "BK-T79U-50",
                    Color = "Blue",
                    ListPrice = 2384.07,
                    Size = "50",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 25.42
                },
                new Product
                {
                    Id = 968,
                    ProductSubcategoryId = 3,
                    ProductModelId = 34,
                    Name = "Touring-1000 Blue, 54",
                    ProductNumber = "BK-T79U-54",
                    Color = "Blue",
                    ListPrice = 2384.07,
                    Size = "54",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 25.68
                },
                new Product
                {
                    Id = 969,
                    ProductSubcategoryId = 3,
                    ProductModelId = 34,
                    Name = "Touring-1000 Blue, 60",
                    ProductNumber = "BK-T79U-60",
                    Color = "Blue",
                    ListPrice = 2384.07,
                    Size = "60",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 25.90
                },
                new Product
                {
                    Id = 970,
                    ProductSubcategoryId = 3,
                    ProductModelId = 35,
                    Name = "Touring-2000 Blue, 46",
                    ProductNumber = "BK-T44U-46",
                    Color = "Blue",
                    ListPrice = 1214.85,
                    Size = "46",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 27.13
                },
                new Product
                {
                    Id = 971,
                    ProductSubcategoryId = 3,
                    ProductModelId = 35,
                    Name = "Touring-2000 Blue, 50",
                    ProductNumber = "BK-T44U-50",
                    Color = "Blue",
                    ListPrice = 1214.85,
                    Size = "50",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 27.42
                },
                new Product
                {
                    Id = 972,
                    ProductSubcategoryId = 3,
                    ProductModelId = 35,
                    Name = "Touring-2000 Blue, 54",
                    ProductNumber = "BK-T44U-54",
                    Color = "Blue",
                    ListPrice = 1214.85,
                    Size = "54",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 27.68
                },
                new Product
                {
                    Id = 973,
                    ProductSubcategoryId = 2,
                    ProductModelId = 27,
                    Name = "Road-350-W Yellow, 40",
                    ProductNumber = "BK-R79Y-40",
                    Color = "Yellow",
                    ListPrice = 1700.99,
                    Size = "40",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 15.35
                },
                new Product
                {
                    Id = 974,
                    ProductSubcategoryId = 2,
                    ProductModelId = 27,
                    Name = "Road-350-W Yellow, 42",
                    ProductNumber = "BK-R79Y-42",
                    Color = "Yellow",
                    ListPrice = 1700.99,
                    Size = "42",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 15.77
                },
                new Product
                {
                    Id = 975,
                    ProductSubcategoryId = 2,
                    ProductModelId = 27,
                    Name = "Road-350-W Yellow, 44",
                    ProductNumber = "BK-R79Y-44",
                    Color = "Yellow",
                    ListPrice = 1700.99,
                    Size = "44",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 16.13
                },
                new Product
                {
                    Id = 976,
                    ProductSubcategoryId = 2,
                    ProductModelId = 27,
                    Name = "Road-350-W Yellow, 48",
                    ProductNumber = "BK-R79Y-48",
                    Color = "Yellow",
                    ListPrice = 1700.99,
                    Size = "48",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 16.42
                },
                new Product
                {
                    Id = 977,
                    ProductSubcategoryId = 2,
                    ProductModelId = 31,
                    Name = "Road-750 Black, 58",
                    ProductNumber = "BK-R19B-58",
                    Color = "Black",
                    ListPrice = 539.99,
                    Size = "58",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 20.79
                },
                new Product
                {
                    Id = 978,
                    ProductSubcategoryId = 3,
                    ProductModelId = 36,
                    Name = "Touring-3000 Blue, 44",
                    ProductNumber = "BK-T18U-44",
                    Color = "Blue",
                    ListPrice = 742.35,
                    Size = "44",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 28.77
                },
                new Product
                {
                    Id = 979,
                    ProductSubcategoryId = 3,
                    ProductModelId = 36,
                    Name = "Touring-3000 Blue, 50",
                    ProductNumber = "BK-T18U-50",
                    Color = "Blue",
                    ListPrice = 742.35,
                    Size = "50",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 29.13
                },
                new Product
                {
                    Id = 980,
                    ProductSubcategoryId = 1,
                    ProductModelId = 22,
                    Name = "Mountain-400-W Silver, 38",
                    ProductNumber = "BK-M38S-38",
                    Color = "Silver",
                    ListPrice = 769.49,
                    Size = "38",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 26.35
                },
                new Product
                {
                    Id = 981,
                    ProductSubcategoryId = 1,
                    ProductModelId = 22,
                    Name = "Mountain-400-W Silver, 40",
                    ProductNumber = "BK-M38S-40",
                    Color = "Silver",
                    ListPrice = 769.49,
                    Size = "40",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 26.77
                },
                new Product
                {
                    Id = 982,
                    ProductSubcategoryId = 1,
                    ProductModelId = 22,
                    Name = "Mountain-400-W Silver, 42",
                    ProductNumber = "BK-M38S-42",
                    Color = "Silver",
                    ListPrice = 769.49,
                    Size = "42",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 27.13
                },
                new Product
                {
                    Id = 983,
                    ProductSubcategoryId = 1,
                    ProductModelId = 22,
                    Name = "Mountain-400-W Silver, 46",
                    ProductNumber = "BK-M38S-46",
                    Color = "Silver",
                    ListPrice = 769.49,
                    Size = "46",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 27.42
                },
                new Product
                {
                    Id = 984,
                    ProductSubcategoryId = 1,
                    ProductModelId = 23,
                    Name = "Mountain-500 Silver, 40",
                    ProductNumber = "BK-M18S-40",
                    Color = "Silver",
                    ListPrice = 564.99,
                    Size = "40",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 27.35
                },
                new Product
                {
                    Id = 985,
                    ProductSubcategoryId = 1,
                    ProductModelId = 23,
                    Name = "Mountain-500 Silver, 42",
                    ProductNumber = "BK-M18S-42",
                    Color = "Silver",
                    ListPrice = 564.99,
                    Size = "42",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 27.77
                },
                new Product
                {
                    Id = 986,
                    ProductSubcategoryId = 1,
                    ProductModelId = 23,
                    Name = "Mountain-500 Silver, 44",
                    ProductNumber = "BK-M18S-44",
                    Color = "Silver",
                    ListPrice = 564.99,
                    Size = "44",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 28.13
                },
                new Product
                {
                    Id = 987,
                    ProductSubcategoryId = 1,
                    ProductModelId = 23,
                    Name = "Mountain-500 Silver, 48",
                    ProductNumber = "BK-M18S-48",
                    Color = "Silver",
                    ListPrice = 564.99,
                    Size = "48",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 28.42
                },
                new Product
                {
                    Id = 988,
                    ProductSubcategoryId = 1,
                    ProductModelId = 23,
                    Name = "Mountain-500 Silver, 52",
                    ProductNumber = "BK-M18S-52",
                    Color = "Silver",
                    ListPrice = 564.99,
                    Size = "52",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 28.68
                },
                new Product
                {
                    Id = 989,
                    ProductSubcategoryId = 1,
                    ProductModelId = 23,
                    Name = "Mountain-500 Black, 40",
                    ProductNumber = "BK-M18B-40",
                    Color = "Black",
                    ListPrice = 539.99,
                    Size = "40",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 27.35
                },
                new Product
                {
                    Id = 990,
                    ProductSubcategoryId = 1,
                    ProductModelId = 23,
                    Name = "Mountain-500 Black, 42",
                    ProductNumber = "BK-M18B-42",
                    Color = "Black",
                    ListPrice = 539.99,
                    Size = "42",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 27.77
                },
                new Product
                {
                    Id = 991,
                    ProductSubcategoryId = 1,
                    ProductModelId = 23,
                    Name = "Mountain-500 Black, 44",
                    ProductNumber = "BK-M18B-44",
                    Color = "Black",
                    ListPrice = 539.99,
                    Size = "44",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 28.13
                },
                new Product
                {
                    Id = 992,
                    ProductSubcategoryId = 1,
                    ProductModelId = 23,
                    Name = "Mountain-500 Black, 48",
                    ProductNumber = "BK-M18B-48",
                    Color = "Black",
                    ListPrice = 539.99,
                    Size = "48",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 28.42
                },
                new Product
                {
                    Id = 993,
                    ProductSubcategoryId = 1,
                    ProductModelId = 23,
                    Name = "Mountain-500 Black, 52",
                    ProductNumber = "BK-M18B-52",
                    Color = "Black",
                    ListPrice = 539.99,
                    Size = "52",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 28.68
                },
                new Product
                {
                    Id = 994,
                    ProductSubcategoryId = 5,
                    ProductModelId = 95,
                    Name = "LL Bottom Bracket",
                    ProductNumber = "BB-7421",
                    Color = null,
                    ListPrice = 53.99,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = "G  ",
                    Weight = 223.00
                },
                new Product
                {
                    Id = 995,
                    ProductSubcategoryId = 5,
                    ProductModelId = 96,
                    Name = "ML Bottom Bracket",
                    ProductNumber = "BB-8107",
                    Color = null,
                    ListPrice = 101.24,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = "G  ",
                    Weight = 168.00
                },
                new Product
                {
                    Id = 996,
                    ProductSubcategoryId = 5,
                    ProductModelId = 97,
                    Name = "HL Bottom Bracket",
                    ProductNumber = "BB-9108",
                    Color = null,
                    ListPrice = 121.49,
                    Size = null,
                    SizeUnitMeasureCode = null,
                    WeightUnitMeasureCode = "G  ",
                    Weight = 170.00
                },
                new Product
                {
                    Id = 997,
                    ProductSubcategoryId = 2,
                    ProductModelId = 31,
                    Name = "Road-750 Black, 44",
                    ProductNumber = "BK-R19B-44",
                    Color = "Black",
                    ListPrice = 539.99,
                    Size = "44",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 19.77
                },
                new Product
                {
                    Id = 998,
                    ProductSubcategoryId = 2,
                    ProductModelId = 31,
                    Name = "Road-750 Black, 48",
                    ProductNumber = "BK-R19B-48",
                    Color = "Black",
                    ListPrice = 539.99,
                    Size = "48",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 20.13
                },
                new Product
                {
                    Id = 999,
                    ProductSubcategoryId = 2,
                    ProductModelId = 31,
                    Name = "Road-750 Black, 52",
                    ProductNumber = "BK-R19B-52",
                    Color = "Black",
                    ListPrice = 539.99,
                    Size = "52",
                    SizeUnitMeasureCode = "CM ",
                    WeightUnitMeasureCode = "LB ",
                    Weight = 20.42
                },
            };
        }
    }
}
