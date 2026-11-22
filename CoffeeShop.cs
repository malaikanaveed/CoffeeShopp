namespace CoffeeShop;

public class CoffeeShopApp
{
    private readonly Menu menu = new Menu();
    private readonly PaymentProcessor paymentProcessor = new PaymentProcessor();

    public void Run()
    {
        Console.WriteLine("Welcome to Malaika's Coffee Shop!");

        bool ordering = true;

        while (ordering)
        {
            menu.DisplayMenu();
            Console.Write("\nSelect an item number: ");

            if (!int.TryParse(Console.ReadLine(), out int choice) ||
                !menu.TryGetItem(choice, out string itemName, out decimal price))
            {
                Console.WriteLine("Invalid menu choice. Please try again.");
                continue;
            }

            Console.Write("Enter quantity: ");
            if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity <= 0)
            {
                Console.WriteLine("Please enter a quantity greater than zero.");
                continue;
            }

            Order order = new Order(itemName, price, quantity);
            order.DisplayOrder();

            Console.Write("\nConfirm order? (Y/N): ");
            string? confirmation = Console.ReadLine();

            if (confirmation != null && confirmation.Trim().Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                paymentProcessor.ProcessPayment(order.CalculateTotal());
            }
            else
            {
                Console.WriteLine("Order cancelled.");
            }

            Console.Write("\nWould you like to place another order? (Y/N): ");
            string? again = Console.ReadLine();
            ordering = again != null && again.Trim().Equals("Y", StringComparison.OrdinalIgnoreCase);
        }

        Console.WriteLine("\nThank you for visiting Malaika's Coffee Shop!");
    }
}
