public class Product
{
    private string _name;
    private string _productID;
    private decimal _price;
    private int _quantity;

    public Product(string name, string product, decimal price, int quantity)
    {
        _name = name;
        _productID = product;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductID()
    {
        return _productID;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public decimal GetTotalCost()
    {
        return _price * _quantity;
    }
}