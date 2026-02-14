using balta_desafio_carnacode_2026_1_abstract_factory.Interface;

namespace balta_desafio_carnacode_2026_1_abstract_factory.Gateway.Stripe;

public class StripeLogger : IPaymentLogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[Stripe Log] {DateTime.Now}: {message}");
    }
}