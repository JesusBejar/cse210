using System;

class Program
{
    static void Main(string[] args)
    {
        List<Product> _productList = new List<Product>();
        // below prints the following
        // 3901 Candy st Utah United States of America
        // USA
        Address a1 = new Address("3901 Candy st", "Utah", "United States of America");
        Console.WriteLine(a1.ReturnAddress());
        Console.WriteLine(a1.CountryIsUSA());

        // below prints the following
        // Elend Musk 3901 Candy st Utah United States of America
        Customer c1 = new Customer("Elend Musk", a1);
        Console.WriteLine(c1.ReturnCustomer());

        Product bonobosPoloShirt = new Product("Soft Air Sweather Polo", "SKU: BF-104058010-UBUO", 3, 109);
        Console.WriteLine(bonobosPoloShirt.ReturnProduct());
        Console.WriteLine($"Total cost: {bonobosPoloShirt.TotalProductPrice()}");
        _productList.Add(bonobosPoloShirt);

        Product championSweats = new Product("CLOSED BOTTOM EVERYDAY COTTON PANTS, 31.5", "Style# P7310-407Q88", 2, 27);
        Console.WriteLine(championSweats.ReturnProduct());
        Console.WriteLine($"Total cost: {championSweats.TotalProductPrice()}");
        _productList.Add(championSweats);

        CustomerOrder o1 = new CustomerOrder(_productList, c1, bonobosPoloShirt.TotalProductPrice(), a1);
        // below will print out the name and product id of each product in the order
        o1.PackingLabel();
        o1.ShippingLabel();
    }
}