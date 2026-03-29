using System.Numerics;

class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double GetTotalCost()
    {
        double total = 0;
        foreach (Product p in _products)
        {
           total += p.GetTotalCost();
        }
        if (_customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }

    public string GetPackingLabel()
    {
        string shopping = "";
        foreach (Product p in _products)
        {
            shopping += $"{p.GetName()} {p.GetId()}\n";
        }
        return shopping;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}