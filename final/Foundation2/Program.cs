using System;

class Program
{
    static void Main(string[] args)
    {
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
    }
}