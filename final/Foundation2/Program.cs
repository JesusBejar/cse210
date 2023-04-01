using System;

class Program
{
    static void Main(string[] args)
    {
        List<Product> _productList1 = new List<Product>();
        // ORDER 1 ------------------------------
        Address a1 = new Address("3901 Candy st", "Monterrey", "Mexico");
        // Console.WriteLine(a1.ReturnAddress());
        // Console.WriteLine(a1.CountryIsUSA());

        Customer c1 = new Customer("Jacob Bejar", a1);
        // Console.WriteLine(c1.ReturnCustomer());

        // PRODUCTS 1 ------------------------------
        Product bonobosPoloShirt = new Product("Soft Air Sweather Polo", "BF-104058010-UBUO", 3, 109);
        _productList1.Add(bonobosPoloShirt);
        // Console.WriteLine(bonobosPoloShirt.ReturnProduct());
        // Console.WriteLine($"Total cost: {bonobosPoloShirt.TotalProductPrice()}");
        
        Product championSweats = new Product("Closed Bottom Everyday Cotton pants 31.5", "P7310-407Q88", 2, 27);
        _productList1.Add(championSweats);
        // Console.WriteLine(championSweats.ReturnProduct());
        // Console.WriteLine($"Total cost: {championSweats.TotalProductPrice()}");
        Product jesusTShirt = new Product("On Earth Premium sand tee","5521", 2, 10);
        _productList1.Add(jesusTShirt);

        // CUSTOMER ORDER 1 ------------------------------
        CustomerOrder o1 = new CustomerOrder(_productList1, c1, a1);
        // below will print out the name and product id of each product in the order
        Console.WriteLine("\nOrder #1 -");
        o1.PackingLabel();
        o1.ShippingLabel();
        // the a2.CountryIsUSA determines if the user address is in the USA and returns a country string
        // the c2.CountryIsUSA then takes the country string and determines if it is USA or not and returns true or false
        // the o2.CalculateCost takes the true or false and adds either 5$ or 35$ to the total cost
        o1.CalculateCost(c1.CountryIsUSA(a1.CountryIsUSA()));
        // ------------------------------

        // ORDER 2 ------------------------------
        List<Product> _productList2 = new List<Product>();
        Address a2 = new Address("525 S Center St", "Rexburg", "United States of America");
        Customer c2 = new Customer("Blanca Perez", a2);
        // PRODUCTS 2 ------------------------------
        Product rubberStick = new Product("Boots & Barkley long rubber chewing stick", "083053312", 1, 10);
        _productList2.Add(rubberStick);
        Product dogKibble = new Product("Taste of the Wild Dog Kibble", "154549", 1, 56);
        _productList2.Add(dogKibble);
        Product puppyMilkReplacer = new Product("Breeder's Edge® Foster Care™ Canine Milk Replacer", "63263-209", 1, 20);
        _productList2.Add(puppyMilkReplacer);

        // CUSTOMER ORDER 2 ------------------------------
        CustomerOrder o2 = new CustomerOrder(_productList2, c2, a2);
        Console.WriteLine("\nOrder #2 -");
        o2.PackingLabel();
        o2.ShippingLabel();
        o2.CalculateCost(c2.CountryIsUSA(a2.CountryIsUSA()));

        // finished
    }
}