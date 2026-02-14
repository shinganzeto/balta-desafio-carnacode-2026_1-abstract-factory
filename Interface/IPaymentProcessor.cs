namespace balta_desafio_carnacode_2026_1_abstract_factory.Interface;

public interface IPaymentProcessor
{
    string ProcessPayment(decimal amount, string cardNumber);
}