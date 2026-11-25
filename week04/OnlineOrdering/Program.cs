using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Wolfstreet 44", "Orlando", "Florida", "USA");
        Customer customer1 = new Customer("Isaac Petersen", address1);
        Order order1 = new Order(customer1);
        Product product1 = new Product("Laptop", "LP101", 800.00, 1);
        Product product2 = new Product("Monitor", "MT67", 100.00, 2);
        Product product3 = new Product("Speakers", "SPK44", 70.85, 4);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Address address2 = new Address("Los Helechos 72", "Guayaquil", "Guayas", "Ecuador");
        Customer customer2 = new Customer("Luciano Mendoza", address2);
        Order order2 = new Order(customer2);
        Product product4 = new Product("Mouse", "M7989", 50.99, 1);
        Product product5 = new Product("Desk", "DK55", 567.00, 2);
        Product product6 = new Product("Trash can", "TC12", 10.50, 5);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($" Total cost: ${order1.CalculateTotalCost()}");

        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($" Total cost: ${order2.CalculateTotalCost()}");

    }
}