public class CustomerOrder
{
    private List<Product> _productList ;
    private Customer _customerList ;
    private int _totalOrderPrice ;
    private Address _address ; 
    public CustomerOrder()
    {

    }
    public void CalculateCost()
    {
        foreach (Product p in _productList)
        {

        }
    }
    public void PackingLabel()
    {
        Console.WriteLine($"Packing label: \n ");
    }
    public void ShippingLabel()
    {
        Console.WriteLine($"Packing label: \n {_address.ReturnAddress()}");
    }

}