using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Foundation 2, Lautaro G. Colazo");
        
        Console.WriteLine("Defining Customers...");
        Address a1 = new Address("Cid Campeador 563", "Río Tercero", "Córdoba", "Argentina");
        Customer c1 = new Customer("Lautaro", a1 );

        Address a2 = new Address("Fake address", "Fake city", "Fake state", "USA");
        Customer c2 = new Customer("John", a2 );

        Console.WriteLine("Creating orders...");
        Order o1 = new Order(c1);
        Order o2 = new Order(c2);


        Product p1 = new Product("Mouse Pad", 111, 16, 1);
        Product p2 = new Product("Headhphones", 222, 56, 1);
        Product p3 = new Product("Smart Watch", 333, 256, 1);

        Product p4 = new Product("Monitor", 444, 146, 1);
        Product p5 = new Product("Battery", 555, 2, 4);
        Product p6 = new Product("Phone", 666, 356, 1);

        Console.WriteLine("Adding products...");
        o1.AddProduct(p1);
        o1.AddProduct(p2);
        o1.AddProduct(p3);

        o1.DisplayPackingLabel();
        o1.DisplayShippingLabel();

        o1.CalculateCost();

        Console.WriteLine($"The total cost of the order is: ${o1.GetPrice()}");

        o2.AddProduct(p4);
        o2.AddProduct(p5);
        o2.AddProduct(p6);

        o2.DisplayPackingLabel();
        o2.DisplayShippingLabel();

        o2.CalculateCost();

        Console.WriteLine($"The total cost of the order is: ${o2.GetPrice()}");
    }
}
