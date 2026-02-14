using balta_desafio_carnacode_2026_1_abstract_factory.Gateway.PagSeguro;
using balta_desafio_carnacode_2026_1_abstract_factory.Interface;

namespace balta_desafio_carnacode_2026_1_abstract_factory.Factories;

public class PagSeguroFactory : IPaymentGatewayFactory
{
    public IPaymentValidator CreateValidator() => new PagSeguroValidator();

    public IPaymentProcessor CreateProcessor() => new PagSeguroProcessor();

    public IPaymentLogger CreateLogger() => new PagSeguroLogger();
}