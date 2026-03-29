using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("\nHello Foundation2 World!\n");
        Console.Clear();

        Address address1 = new Address("123 Main", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Jacob Derington", address1);

        List<Product> products1 = new List<Product>();
        products1.Add(new Product("Mountain Dew", "D001", 3.5, 24));

        Order order1 = new Order(products1, customer1);

        Address address2 = new Address("456 King Rd", "Richmond", "BC", "Canada");
        Customer customer2 = new Customer("Steve Trueman", address2);

        List<Product> products2 = new List<Product>();
        products2.Add(new Product("Cheese Curds", "C001", 10.0, 3));
        products2.Add(new Product("Gravy", "G001", 1.5, 5));
        products2.Add(new Product("Fries", "F001", 15.25, 2));

        Order order2 = new Order(products2, customer2);

        Console.WriteLine("ORDER 1");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}\n");
        
        Console.WriteLine("--------------------\n");

        Console.WriteLine("ORDER 2");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}\n");
    }
}