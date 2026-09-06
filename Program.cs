namespace AdvancedC_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> Catalog = new()
            {
                new Product {Id= 1, Name="Laptop", Category="Electronics", Price=1200, Stock=10},
                new Product {Id= 2, Name="Phone", Category="Electronics", Price=800, Stock=25},
                new Product {Id= 3, Name="T-Shirt", Category="Clothing", Price=30, Stock=100},
                new Product {Id= 4, Name="Jeans", Category="Clothing", Price=60, Stock=50},
                new Product {Id= 5, Name="Chocolate", Category="Food", Price=5, Stock=200},
                new Product {Id= 6, Name="Coffee Beans", Category="Food", Price=15, Stock=80},
                new Product {Id= 7, Name="C# Book", Category="Books", Price=45, Stock=30},
                new Product {Id= 8, Name="Novel", Category="Books", Price=20, Stock=60},
                new Product {Id= 9, Name="Headphones", Category="Electronics", Price=150, Stock=40},
                new Product {Id= 10, Name="Jacket", Category="Clothing", Price=120, Stock=15}
            };

            #region Task 01 : Smart Product Search
            /*
             * Manager: "Customers search in all kinds of ways - by category, by price, by name, by stock... 
                and the list keeps growing. 
                I need ONE search method that works for any filter, now and in the future, without being modified”.

                call this method four times with different lambda expressions to perform the following searches:
                1. All Electronics products
                2. Products cheaper than $50
                3. Products that are in stock (Stock > 0)
                4. Clothing products under $100
             */
            //Console.WriteLine("---Electronics---");
            //Product.SearchProducts(Catalog, pro => pro.Category == "Electronics"); // All Electronics products
            //Console.WriteLine();
            //Console.WriteLine("---Under $50---");
            //Product.SearchProducts(Catalog, pro => pro.Price < 50); // Products cheaper than 50
            //Console.WriteLine();
            //Console.WriteLine("---In Stock---");
            //Product.SearchProducts(Catalog, pro => pro.Stock > 0); // Products that are in stock
            //Console.WriteLine();
            //Console.WriteLine("---Clothing under $100---");
            //Product.SearchProducts(Catalog, pro => pro.Category == "Clothing" && pro.Price < 100); //Clothing products under $100
            #endregion

            #region Task 03 : Custom Report Generator
            /*
             Manager: "We need different reports from the same data - a quick summary,
             a detailed breakdown, a low-stock alert. Build one reporting engine where
             the caller controls the format. Use the built-in delegates this time."
             */
            #region 3.1 Print Reports
            /*
            The caller decides what to print by passing a lambda.
            Scenario 1 Short Report: Print each product as Name - $Price
            Scenario 2 Detailed Report: Print each product as [Category] Name | Price: $X | Stock: Y
             */

            //Console.WriteLine("---Short Report---");
            //Product.PrintReport(Catalog, product => Console.WriteLine($"{product.Name} - ${product.Price}")); // Short Report
            //Console.WriteLine();
            //Console.WriteLine("---Detailed Report---");
            //Product.PrintReport(Catalog, product => Console.WriteLine($"[{product.Category}] {product.Name} | Price: ${product.Price} | Stock: {product.Stock}")); // Detailed Report
            #endregion
            #endregion
        }
    }
}
