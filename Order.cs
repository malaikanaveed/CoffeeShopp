namespace CoffeeShop;

public class Order
{
    public string ItemName { get; private set; }
    public decimal UnitPrice { get; private set; }
    public int Quantity { get; private set; }

    public Order(string itemName, decimal unitPrice, int quantity)
    {
        ItemName = itemName;
        UnitPrice = unitPrice;
        Quantity = quantity;
    }

    public decimal CalculateTotal()
    {
        return UnitPrice * Quantity;
    }

    public void DisplayOrder()
    {
        Console.WriteLine("\n----- ORDER SUMMARY -----");
        Console.WriteLine($"Item: {ItemName}");
        Console.WriteLine($"Price: Rs. {UnitPrice}");
        Console.WriteLine($"Quantity: {Quantity}");
        Console.WriteLine($"Total: Rs. {CalculateTotal()}");
    }
}
