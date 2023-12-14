using System.Dynamic;

public class Order
{
    List<Product> products = new List<Product>{};
    Customer customer = new Customer();
    Address address = new Address();
    Product product = new Product();

    

    public Order(Customer _customer)
    {
        customer = _customer;
        products = new List<Product>();
    }

    public void DisplayOrderCost()
    {
        
        double sum = 0;

        foreach (Product product in products)
        {
            sum += product.Total();
        }
        if (customer.IsInUsa())
        {
            sum += 5;
        }
        else 
        {
            sum += 35;
        }
        
        Console.WriteLine($"\nTotal cost of the order: {sum}");

    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void DisplayOrderLabel()
    {
        Console.WriteLine("\nThese are the order labels: ");
        foreach (Product product in products)
        {
            Console.WriteLine(product.Label());
        }

    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine("\nShipping Label");
        Console.WriteLine(customer.GetLabel());
    }


}


