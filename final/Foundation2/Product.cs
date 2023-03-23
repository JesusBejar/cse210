public class Product
{
    private string _name ;
    private string _id ;
    private int _quantity ;
    private int _totalPrice ;

    public Product ()
    {

    }
    public string ReturnProduct()
    {
        return $"{_name} {_id}";
    }

    public int TotalProductPrice()
    {
        return _quantity * _totalPrice;
    }
}