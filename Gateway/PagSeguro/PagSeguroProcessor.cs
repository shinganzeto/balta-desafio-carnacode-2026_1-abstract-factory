using balta_desafio_carnacode_2026_1_abstract_factory.Interface;

namespace balta_desafio_carnacode_2026_1_abstract_factory.Gateway.PagSeguro;

public class PagSeguroProcessor : IPaymentProcessor
{
    public string ProcessPayment(decimal amount, string cardNumber)
    {
        Console.WriteLine($"PagSeguro: Processando R$ {amount}...");
        return $"PAGSEG-{Guid.NewGuid().ToString().Substring(0, 8)}";
    }
}