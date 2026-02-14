using balta_desafio_carnacode_2026_1_abstract_factory.Factories;
using balta_desafio_carnacode_2026_1_abstract_factory.Services;

var pagSeguroService = new PaymentService(new PagSeguroFactory());
pagSeguroService.ProcessPayment(264.00m, "1234567890123456");

Console.WriteLine();

var mercadoPagoService = new PaymentService(new MercadoPagoFactory());
mercadoPagoService.ProcessPayment(184.50m, "5234567890123456");

Console.WriteLine();

var stripeService = new PaymentService(new StripeFactory());
stripeService.ProcessPayment(746.75m, "4234567890123456");