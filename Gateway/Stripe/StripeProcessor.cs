using balta_desafio_carnacode_2026_1_abstract_factory.Interface;

namespace balta_desafio_carnacode_2026_1_abstract_factory.Gateway.Stripe;

public class StripeProcessor : IPaymentProcessor
{
    public string ProcessPayment(decimal amount, string cardNumber)
    {
        Console.WriteLine($"Stripe: Processando ${amount}...");
        return $"STRIPE-{Guid.NewGuid().ToString().Substring(0, 8)}";
    }

}