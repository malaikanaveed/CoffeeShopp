namespace CoffeeShop;

public class PaymentProcessor
{
    public bool ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Payment of Rs. {amount} received.");
        Console.WriteLine("Payment successful!");
        return true;
    }
}
