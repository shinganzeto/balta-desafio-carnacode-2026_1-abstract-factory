namespace balta_desafio_carnacode_2026_1_abstract_factory.Interface;

public interface IPaymentValidator
{
    bool ValidateCard(string cardNumber);
}