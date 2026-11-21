using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Address address1 = new Address("123 The Beuty Street Idk..", "Austin", "TX", "USA");
        Customer customer1 = new Customer("Samuel Rendon", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Water Bottle", "001", 15.0, 2));
        order1.AddProduct(new Product("Laptop Stand", "002", 40.0, 1));
        order1.AddProduct(new Product("Mouse Pad", "003", 10.0, 1));
        orders.Add(order1);

        Address address2 = new Address("Random Street in Canada", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Nicolas Rendon", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("A Desk", "004", 20.0, 2));
        order2.AddProduct(new Product("A Calculator", "005", 8.0, 3));
        orders.Add(order2);

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine();
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine();
            Console.WriteLine($"Total Price: ${order.CalculateTotalCost():F2}");
        }
    }
}