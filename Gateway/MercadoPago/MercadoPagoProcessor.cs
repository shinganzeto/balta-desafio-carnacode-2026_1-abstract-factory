using balta_desafio_carnacode_2026_1_abstract_factory.Interface;

namespace balta_desafio_carnacode_2026_1_abstract_factory.Gateway.MercadoPago;

public class MercadoPagoProcessor : IPaymentProcessor
{
    public string ProcessPayment(decimal amount, string cardNumber)
    {
        Console.WriteLine($"MercadoPago: Processando R$ {amount}...");
        return $"MP-{Guid.NewGuid().ToString().Substring(0, 8)}";
    }
}