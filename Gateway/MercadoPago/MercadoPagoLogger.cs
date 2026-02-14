using balta_desafio_carnacode_2026_1_abstract_factory.Interface;

namespace balta_desafio_carnacode_2026_1_abstract_factory.Gateway.MercadoPago;

public class MercadoPagoLogger : IPaymentLogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[MercadoPago Log] {DateTime.Now}: {message}");
    }
}