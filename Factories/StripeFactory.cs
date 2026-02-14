using balta_desafio_carnacode_2026_1_abstract_factory.Gateway.Stripe;
using balta_desafio_carnacode_2026_1_abstract_factory.Interface;

namespace balta_desafio_carnacode_2026_1_abstract_factory.Factories;

public class StripeFactory : IPaymentGatewayFactory
{
    public IPaymentValidator CreateValidator() => new StripeValidator();

    public IPaymentProcessor CreateProcessor() => new StripeProcessor();

    public IPaymentLogger CreateLogger() =>  new StripeLogger();
    
}