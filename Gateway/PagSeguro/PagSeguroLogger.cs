using balta_desafio_carnacode_2026_1_abstract_factory.Interface;

namespace balta_desafio_carnacode_2026_1_abstract_factory.Gateway.PagSeguro;

public class PagSeguroLogger : IPaymentLogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[PagSeguro Log] {DateTime.Now}: {message}");
    }
}