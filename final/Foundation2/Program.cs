using System;

class Program
{
    static void Main(string[] args)
    {
        List<Product> _productList = new List<Product>();

        // ORDER 1 ------------------------------
        Address a1 = new Address("3901 Candy st", "Colorado", "United States of America");
        // Console.WriteLine(a1.ReturnAddress());
        // Console.WriteLine(a1.CountryIsUSA());
        // prints the following
        // 3901 Candy st Utah United States of America
        // USA

        Customer c1 = new Customer("Jacob Bejar", a1);
        // Console.WriteLine(c1.ReturnCustomer());
        // prints the following
        // Elend Musk 3901 Candy st Utah United States of America

        // PRODUCTS 1 ------------------------------
        Product bonobosPoloShirt = new Product("Soft Air Sweather Polo", "BF-104058010-UBUO", 3, 109);
        // Console.WriteLine(bonobosPoloShirt.ReturnProduct());
        // Console.WriteLine($"Total cost: {bonobosPoloShirt.TotalProductPrice()}");
        _productList.Add(bonobosPoloShirt);
        // prints the following
        // Soft Air Sweather Polo SKU: BF-104058010-UBUO
        // Total cost: 327

        Product championSweats = new Product("Closed Bottom Everyday Cotton pants 31.5", "P7310-407Q88", 2, 27);
        // Console.WriteLine(championSweats.ReturnProduct());
        // Console.WriteLine($"Total cost: {championSweats.TotalProductPrice()}");
        _productList.Add(championSweats);
        // prints the following
        // CLOSED BOTTOM EVERYDAY COTTON PANTS, 31.5 Style# P7310-407Q88
        // Total cost: 54

        // CUSTOMER ORDER 1 ------------------------------
        CustomerOrder o1 = new CustomerOrder(_productList, c1, bonobosPoloShirt.TotalProductPrice(), a1);
        // below will print out the name and product id of each product in the order
        Console.WriteLine("Order #1 -");
        o1.PackingLabel();
        o1.ShippingLabel();
        o1.CalculateCost(_productList);
        // ------------------------------

        // ORDER 2 ------------------------------
        Address a2 = new Address("525 S Center St", "Rexburg", "United States of America");
        Customer c2 = new Customer("Blanca Perez", a2);
        // PRODUCTS 2 ------------------------------
        Product rubberStick = new Product("Boots & Barkley long rubber chewing stick", "083-05-3312", 1, 10);
        _productList.Add(rubberStick);
        Product dogKibble = new Product("Taste of the Wild Dog Kibble", "154549", 1, 56);
        _productList.Add(dogKibble);

        // CUSOTOMER ORDER 2 ------------------------------
        CustomerOrder o2 = new CustomerOrder(_productList, c2, rubberStick.TotalProductPrice(), a2);
        // below will print out the name and product id of each product in the order
        Console.WriteLine("Order # -");
        o2.PackingLabel();
        o2.ShippingLabel();
        o2.CalculateCost(_productList);

    }
}