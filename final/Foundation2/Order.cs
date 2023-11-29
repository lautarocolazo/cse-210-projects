public class Order
{
  private List<Product> _products = new List<Product>();
  private Customer _customer;
  private int _finalPrice;

  public Order(Customer customer)
  {
    _customer = customer;
  }

  public void AddProduct(Product product)
  {
    _products.Add(product);
  }

  public void CalculateCost()
  {

    foreach (Product product in _products)
    {
      _finalPrice += product.CalculatePrice();
    }

    if (_customer.LiveInUSA() == true)
    {
      _finalPrice = _finalPrice + 5;
    }
    else
    {
      _finalPrice = _finalPrice + 35;
    }
  }

  public int GetPrice()
  {
    return _finalPrice;
  }

  public void DisplayPackingLabel()
  {
    Console.WriteLine("### PACKING LABEL ###");
    foreach (Product product in _products)
    {
      Console.WriteLine($"Product name: {product.GetName()}, product ID: {product.GetID()}");
      Console.WriteLine("-----------------------------------");
    }
  }

  public void DisplayShippingLabel()
  {
    Console.WriteLine("### SHIPPING LABEL ###");
    Console.WriteLine($"{_customer.GetName()}, {_customer.GetAddress()}");
  }

  }
