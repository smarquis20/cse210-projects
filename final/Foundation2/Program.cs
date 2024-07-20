using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Asus Laptop", "A100", 1399.99m, 2);
        Product product2 = new Product("Gaming Mouse", "A101", 89.99m, 1);
        Product product3 = new Product("Mouse Pad", "A102", 9.99m, 2);
        Product product4 = new Product("Desk", "A103", 400.00m, 2);
        Product product5 = new Product("Ipad Pro", "A104", 899.99m, 2);
        Product product6 = new Product("Backpack", "A105", 250.99m, 2);

        Address address1 = new Address("13725 White Meadow Ct", "Johnson City", "TN", "USA");
        Address address2 = new Address("123 Main St", "Calgary", "AL", "Canada");

        Customer customer1 = new Customer("Shaun Marquis", address1);
        Customer customer2 = new Customer("Mike Morrell", address2);

        List<Product> orderList1 = new List<Product>{product1, product2, product3, product6};
        List<Product> orderList2 = new List<Product>{product4, product5, product6};

        Order order1 = new Order(orderList1, customer1);
        Order order2 = new Order(orderList2, customer2);

        Console.WriteLine($"Customer Name: {customer1.GetName()}");
        Console.WriteLine();

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine("Shipping Cost:");
        Console.WriteLine($"${order1.GetShippingCost()}");
        Console.WriteLine("Order Total:");
        Console.WriteLine($"${order1.GetTotal()}");
        Console.WriteLine();

        Console.WriteLine($"Customer Name: {customer2.GetName()}");
        Console.WriteLine();

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine("Shipping Cost:");
        Console.WriteLine($"${order2.GetShippingCost()}");
        Console.WriteLine("Order Total:");
        Console.WriteLine($"${order2.GetTotal()}");
        Console.WriteLine();
    }
}