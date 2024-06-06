using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Clear();

        Address _address = new Address("123 Main Street", "Anytown", "CA", "USA");
        Customer _customer = new Customer("Mary Anthony",_address);

        Order _order = new Order(_customer);
        _order.AddProduct(new Product("Apple Juice","1001", 25.3m,2));
        _order.AddProduct(new Product("Whole Wheat Bread","1002", 50.2m));
        _order.AddProduct(new Product("Cheddar Cheese","1003", 39.0m));

        Console.WriteLine("---------------------");
        Console.WriteLine("---------------------");
        Console.WriteLine("----Order Details----");
        Console.WriteLine("---------------------");
        Console.WriteLine("---------------------");
        Console.WriteLine(string.Format("{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}", "Product Name","Product ID","Price","Quantity","Total Cost"));
        Console.WriteLine($"{_order.GetPackingLabel()}");
        Console.WriteLine(_order.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${_order.GetTotalCost()}");

        Address _address2 = new Address("12 Broad Street", "Lagos Island", "Lagos", "NIG");
        Customer _customer2 = new Customer("John Wick",_address2);

        Order _order2 = new Order(_customer2);
        _order2.AddProduct(new Product("Organic Milk","1004", 18.2m));
        _order2.AddProduct(new Product("Rice Cakes","1005", 20.6m));
        _order2.AddProduct(new Product("Canned Tuna","1006", 60.4m,3));

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("---------------------");
        Console.WriteLine("---------------------");
        Console.WriteLine("----Order Details----");
        Console.WriteLine("---------------------");
        Console.WriteLine("---------------------");
        Console.WriteLine(string.Format("{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}", "Product Name","Product ID","Price","Quantity","Total Cost"));
        Console.WriteLine(_order2.GetPackingLabel());
        Console.WriteLine(_order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${_order2.GetTotalCost()}");
        Console.WriteLine();
        Console.WriteLine();
    }
}