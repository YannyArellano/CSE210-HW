using System;

class Program
{
    static void Main(string[] args)
    {
        // ===== Order 1 =====
        Address a1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer c1 = new Customer("Michael Smith", a1);
        Order o1 = new Order(c1);

        o1.AddProduct(new Product("Laptop", "L123", 1200, 1));
        o1.AddProduct(new Product("USB Cable", "U456", 5, 3));

        // ===== Order 2 =====
        Address a2 = new Address("Avenida Siempre Viva 742", "Lima", "Lima", "Peru");
        Customer c2 = new Customer("Ana Martínez", a2);
        Order o2 = new Order(c2);

        o2.AddProduct(new Product("Headphones", "H789", 50, 2));
        o2.AddProduct(new Product("Smartwatch", "S321", 150, 1));

        // ===== Output =====
        Console.WriteLine("ORDER 1");
        Console.WriteLine(o1.GetPackingLabel());
        Console.WriteLine(o1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${o1.GetTotalPrice()}\n");

        Console.WriteLine("ORDER 2");
        Console.WriteLine(o2.GetPackingLabel());
        Console.WriteLine(o2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${o2.GetTotalPrice()}");
    }
}