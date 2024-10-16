public class Order
{
    private List<Product> products;
    private Customer customer;

    // Constructor
    public Order(Customer customer)
    {
        this.products = new List<Product>();
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal total = 0;

        foreach (Product product in products)
        {
            total += product.GetTotalCost();
        }

        // Add shipping cost
        total += customer.LivesInUSA() ? 5 : 35;

        return total;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in products)
        {
            packingLabel += $"{product.GetPackingLabel()}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.GetShippingLabel()}";
    }
}