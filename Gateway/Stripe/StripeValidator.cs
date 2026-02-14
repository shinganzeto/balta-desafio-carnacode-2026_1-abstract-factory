using balta_desafio_carnacode_2026_1_abstract_factory.Interface;

namespace balta_desafio_carnacode_2026_1_abstract_factory.Gateway.Stripe;

public class StripeValidator : IPaymentValidator
{
    public bool ValidateCard(string cardNumber)
    {
        Console.WriteLine("Stripe: Validando cartão...");
        return cardNumber.Length == 16 && cardNumber.StartsWith("4");
    }
}