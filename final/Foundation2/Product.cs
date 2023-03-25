public class Product
{
    private string _name ;
    private string _id ;
    private int _quantity ;
    private int _price ;
    public Product (string name, string id, int quantity, int price)
    {
        _name = name;
        _id = id;
        _quantity = quantity;
        _price = price;
    }
    public string ReturnProduct()
    {
        return $"{_name} {_id}";
    }

    public int TotalProductPrice()
    {
        return _quantity * _price;
    }
}