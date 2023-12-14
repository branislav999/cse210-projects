public class Product
{
    private string name;
    private string productId;
    private double price;
    private int quantity;
    


    public Product()
    {

    }
    public Product(string _name, string _productId, double _price, int _quantity)
    {
        name = _name;
        productId = _productId;
        price = _price;
        quantity = _quantity;

    }

    public double Total()
    {
        return price * quantity;   
    }

    public string Label()
    {
        return $"Name of the product: {name}, Product ID: {productId}";
    }


}
