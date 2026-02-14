using balta_desafio_carnacode_2026_1_abstract_factory.Interface;

namespace balta_desafio_carnacode_2026_1_abstract_factory.Gateway.MercadoPago;

public class MercadoPagoValidator : IPaymentValidator
{
    public bool ValidateCard(string cardNumber)
    {
        Console.WriteLine("MercadoPago: Validando cartão...");
        return cardNumber.Length == 16 && cardNumber.StartsWith("5");
    }
}