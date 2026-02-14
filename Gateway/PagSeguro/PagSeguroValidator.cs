using balta_desafio_carnacode_2026_1_abstract_factory.Interface;

namespace balta_desafio_carnacode_2026_1_abstract_factory.Gateway.PagSeguro;

public class PagSeguroValidator : IPaymentValidator
{
    public bool ValidateCard(string cardNumber) 
    {
        Console.WriteLine("PagSeguro: Validando cartão...");
        return cardNumber.Length == 16;
    }
}