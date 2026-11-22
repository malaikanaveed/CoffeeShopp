namespace CoffeeShop;

public class Menu
{
    private readonly Dictionary<int, (string Name, decimal Price)> items =
        new Dictionary<int, (string Name, decimal Price)>
        {
            { 1, ("Coffee", 350m) },
            { 2, ("Cappuccino", 450m) },
            { 3, ("Latte", 500m) },
            { 4, ("Tea", 200m) }
        };

    public void DisplayMenu()
    {
        Console.WriteLine("\n----- COFFEE SHOP MENU -----");
        foreach (var item in items)
        {
            Console.WriteLine($"{item.Key}. {item.Value.Name} - Rs. {item.Value.Price}");
        }
    }

    public bool TryGetItem(int choice, out string name, out decimal price)
    {
        if (items.ContainsKey(choice))
        {
            name = items[choice].Name;
            price = items[choice].Price;
            return true;
        }

        name = "";
        price = 0;
        return false;
    }
}
