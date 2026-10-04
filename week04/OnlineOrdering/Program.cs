using System;

namespace OnlineOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            // Order 1: USA Customer
            Address address1 = new Address("123 Maple Street", "Springfield", "IL", "USA");
            Customer customer1 = new Customer("Alice Johnson", address1);
            Order order1 = new Order(customer1);

            Product product1 = new Product("Wireless Mouse", "M100", 25.99, 2);
            Product product2 = new Product("Mechanical Keyboard", "K200", 89.50, 1);
            Product product3 = new Product("USB-C Cable", "C300", 12.00, 3);

            order1.AddProduct(product1);
            order1.AddProduct(product2);
            order1.AddProduct(product3);

            // Order 2: Non-USA Customer
            Address address2 = new Address("456 Queen Street West", "Toronto", "ON", "Canada");
            Customer customer2 = new Customer("Bob Smith", address2);
            Order order2 = new Order(customer2);

            Product product4 = new Product("27-inch Monitor", "MON70", 249.99, 1);
            Product product5 = new Product("Desk Mat", "DM10", 19.95, 2);

            order2.AddProduct(product4);
            order2.AddProduct(product5);

            // Display Order 1 Details
            Console.WriteLine("========================================");
            Console.WriteLine("               ORDER 1                  ");
            Console.WriteLine("========================================");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine();
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine();
            Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}");
            Console.WriteLine();

            // Display Order 2 Details
            Console.WriteLine("========================================");
            Console.WriteLine("               ORDER 2                  ");
            Console.WriteLine("========================================");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine();
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine();
            Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}");
            Console.WriteLine("========================================");
        }
    }
}