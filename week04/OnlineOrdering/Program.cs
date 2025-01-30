using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Urbanizacion El Cedral", "San Pedro", "San Jose", "Costa Rica");
        Address address2 = new Address("Villas de Tulin", "San Pedro", "San Jose", "Costa Rica");

        Customer customer1 = new Customer("Santiago Meneses", address1);
        Customer customer2 = new Customer("Sebastian Hidalgo", address2);

        Product product1 = new Product("Laptop", 101, 899.99, 1);
        Product product2 = new Product("Headphones", 102, 199.99, 2);
        Product product3 = new Product("Mouse", 103, 49.99, 3);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():0.00}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():0.00}");
    }
}
