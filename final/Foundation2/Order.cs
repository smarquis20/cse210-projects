using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public decimal GetTotal()
    {
        decimal total = 0;
        decimal shippingCost;

        foreach (var product in _products)
        {
            total += product.GetTotalCost();
        }

        if (_customer.InUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        return total + shippingCost;
    }
    
    public decimal GetShippingCost()
    {
        decimal shippingCost;
        if (_customer.InUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        return shippingCost;
    }

    // used to help create a returnable packing list https://www.geeksforgeeks.org/stringbuilder-in-c-sharp/
    public string GetPackingLabel()
    {
        StringBuilder packing = new StringBuilder();
        foreach (var product in _products)
        {
            packing.AppendLine($"Product Name: {product.GetName()}");
            packing.AppendLine($"Product ID: {product.GetProductID()}");
            packing.AppendLine($"Product Quantity: {product.GetQuantity()}");
        }

        return packing.ToString();
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetCustAddress()}";
    }

}