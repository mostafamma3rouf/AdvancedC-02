using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

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

        //Write a method called PrintReport that accepts the product list and an Action.
        public static void PrintReport(List<Product> products, Action<Product> reportAction)
        {
            // loops through all products and calls the action on each one
            foreach (Product product in products)
            {
                reportAction(product);
            }
        }

        // Write a method called TransformProducts that accepts the product list and a Func.
        public static void TransformProducts(List<Product> products, Func<Product, string> transformFunction)
        {
            foreach (Product product in products)
            {
                string transformed = transformFunction(product);
                Console.WriteLine(transformed);
            }
        }

        // Write a method called FilterProducts that accepts the product list and
        // a Predicate.The method returns a List of products that match the condition.
        public static void FilterProducts(List<Product> products, Predicate<Product> filter)
        {
            List<Product> filteredProducts = new List<Product>();
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
                Console.WriteLine($"[LOW STOCK] {product.Name} - only {product.Stock} left!");
            }
        }
    }
}
