using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedC_02
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        /*
         * Write a single method called SearchProducts that accepts two parameters:
         * 1. The product list (List<Product>)
         * 2. A delegate representing the filter condition (Func<Product , bool>)
         */
        public static void SearchProducts(List<Product> products, Func<Product, bool> filter)
        {
            List<Product> filteredProducts = new List<Product>(); // new List containing only the products that satisfy the condition.
            foreach (Product product in products)
            {
                if (filter(product))
                {
                    filteredProducts.Add(product);
                }
            }

            // Display the filtered products
            foreach (Product product in filteredProducts)
            {
                Console.WriteLine($"{product.Name} - ${product.Price} (Stock: {product.Stock})");
            }
        }
    }
}
