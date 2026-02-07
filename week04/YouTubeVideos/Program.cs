using System;

class Program
{
    static void Main(string[] args)
    {
        Address usaAddress = new Address("123 Maple St", "Provo", "UT", "USA");
        Customer usaCustomer = new Customer("Cameron Andrews", usaAddress);

        Order order1 = new Order(usaCustomer);
        order1.AddProduct(new Product("Mouse Pad", "MP-1001", 9.99m, 2));
        order1.AddProduct(new Product("Mechanical Keyboard", "KB-2040", 79.50m, 1));
        order1.AddProduct(new Product("USB-C Cable", "CB-3322", 12.00m, 3));

        Address intlAddress = new Address("88 Queen St", "Toronto", "ON", "Canada");
        Customer intlCustomer = new Customer("Sequoia R.", intlAddress);

        Order order2 = new Order(intlCustomer);
        order2.AddProduct(new Product("Notebook", "NB-7781", 4.25m, 5));
        order2.AddProduct(new Product("Gel Pens (Pack)", "PN-1100", 7.80m, 2));

        DisplayOrder(order1);
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine("========================================");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalCost():0.00}");
        Console.WriteLine();
    }
}
