using balta_desafio_carnacode_2026_1_abstract_factory.Factories;
using balta_desafio_carnacode_2026_1_abstract_factory.Interface;

namespace balta_desafio_carnacode_2026_1_abstract_factory.Services;

public class PaymentService
{
    private readonly IPaymentValidator _validator;
    private readonly IPaymentProcessor _processor;
    private readonly IPaymentLogger _logger;

    public PaymentService(IPaymentGatewayFactory factory)
    {
        _validator = factory.CreateValidator();
        _processor = factory.CreateProcessor();
        _logger = factory.CreateLogger();
    }

    public void ProcessPayment(decimal amount, string cardNumber)
    {
        if (!_validator.ValidateCard(cardNumber))
        {
            Console.WriteLine("Cartão inválido");
            return;
        }

        var result = _processor.ProcessPayment(amount, cardNumber);
        _logger.Log($"Transação processada: {result}");
    }
}
