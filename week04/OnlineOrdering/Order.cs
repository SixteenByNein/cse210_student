class Order()
{

    List<Product> _products;
    Customer _customer;


    public void SetOrder(List<Product> products, Customer customer)
    {

        _products = products;
        _customer = customer;

    }

    public double Cost()
    {

        double shipping = (Convert.ToDouble(_customer.Local()) * 30) + 5;

        double preshipping = 0;

        foreach(Product item in _products)
        {

            preshipping += item.Total();

        }

        double total = preshipping + shipping;

        return total;

    }

    public void PackingLabel()
    {

        Console.WriteLine("");
        foreach(Product item in _products)
        {

        Console.WriteLine($"{item.GetName()} ID: ({item.GetId()}) x {item.GetQuantity()}");
        Console.WriteLine($"    ${item.GetPrice()} each x {item.GetQuantity()} = ${Math.Round(item.GetPrice() * item.GetQuantity(), 2)}");

        Console.WriteLine($"Shipping: ${(Convert.ToDouble(_customer.Local()) * 30) + 5}");
        Console.WriteLine($"TOTAL: ${Cost()}");

        }


    }



    public void ShippingLabel()
    {

        Console.WriteLine("");
        Console.WriteLine($"{_customer.GetName()}");
        Console.WriteLine($"{_customer.GetAddress()}");

    }

}