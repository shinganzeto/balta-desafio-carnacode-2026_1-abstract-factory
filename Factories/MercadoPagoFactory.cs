using balta_desafio_carnacode_2026_1_abstract_factory.Gateway.MercadoPago;
using balta_desafio_carnacode_2026_1_abstract_factory.Interface;

namespace balta_desafio_carnacode_2026_1_abstract_factory.Factories;

public class MercadoPagoFactory : IPaymentGatewayFactory
{
    public IPaymentValidator CreateValidator() => new MercadoPagoValidator();
    public IPaymentProcessor CreateProcessor() => new MercadoPagoProcessor();
    public IPaymentLogger CreateLogger() => new MercadoPagoLogger();
}
