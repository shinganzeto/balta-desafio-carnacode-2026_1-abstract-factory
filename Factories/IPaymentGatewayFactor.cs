using balta_desafio_carnacode_2026_1_abstract_factory.Interface;

namespace balta_desafio_carnacode_2026_1_abstract_factory.Factories;

public interface IPaymentGatewayFactory
{
    IPaymentValidator CreateValidator();
    IPaymentProcessor CreateProcessor();
    IPaymentLogger CreateLogger();
}
