public class CustomerOrder
{
    private List<Product> _productList ;
    private Customer _customer ;
    private int _totalOrderPrice ;
    private Address _address ; 
    public CustomerOrder(List<Product> productList, Customer customer, Address address)
    {
        _productList = productList;
        _customer = customer;
        _address = address;
    }
    public int CalculateCost(bool trueOrFalse)
    {
        _totalOrderPrice = 0;
        // if (bool varibale) checks to see if the bool variable is true or false
        // use keywords/variable names not true or false
        if (trueOrFalse)
        {
            _totalOrderPrice += 5;
        }
        else if (!trueOrFalse)
        {
            // why is this code "unreachable"?
            _totalOrderPrice += 35;
        }

        foreach (Product p in _productList)
        {
            // Console.WriteLine(p.TotalProductPrice());
            _totalOrderPrice += p.TotalProductPrice();
            // Console.WriteLine(_totalOrderPrice);
        }
        Console.WriteLine($"Total cost - ${_totalOrderPrice}");
        return _totalOrderPrice;
    }
    public void PackingLabel()
    {
        Console.WriteLine("Packing label----------");
        foreach (Product p in _productList)
        {
            Console.WriteLine($"{p.ReturnProduct()} ");
        }
    }
    public void ShippingLabel()
    {
        Console.WriteLine($"Shipping label----------\n{_customer.ReturnCustomer()}");
    }

}