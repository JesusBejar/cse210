public class CustomerOrder
{
    private List<Product> _productList ;
    private Customer _customer ;
    private int _totalOrderPrice ;
    private Address _address ; 
    public CustomerOrder(List<Product> productList, Customer customer, int totalOrderPrice, Address address)
    {
        _productList = productList;
        _customer = customer;
        _totalOrderPrice = totalOrderPrice;
        _address = address;
    }
    public int CalculateCost(List<Product> productList)
    {
        // _totalOrderPrice = 0;
        foreach (Product p in _productList)
        {
            _totalOrderPrice += p.TotalProductPrice();
        }
        Console.WriteLine($" Total cost - ${_totalOrderPrice}");
        return _totalOrderPrice;
    }
    public void PackingLabel()
    {
        Console.WriteLine("Packing label:");
        foreach (Product p in _productList)
        {
            Console.WriteLine($"{p.ReturnProduct()} ");
        }
        _productList.Clear();
    }
    public void ShippingLabel()
    {
        Console.WriteLine($"Shipping label:\n{_customer.ReturnCustomer()}");
    }

}