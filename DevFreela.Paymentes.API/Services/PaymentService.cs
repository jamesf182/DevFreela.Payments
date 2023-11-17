using DevFreela.Paymentes.API.Models;

namespace DevFreela.Paymentes.API.Services
{
    public class PaymentService : IPaymentService
    {
        public Task<bool> Process(PaymentInfoInputModel paymentInfoInput)
        {
            return Task.FromResult(true);
        }
    }
}
