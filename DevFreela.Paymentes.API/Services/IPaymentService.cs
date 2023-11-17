using DevFreela.Paymentes.API.Models;

namespace DevFreela.Paymentes.API.Services
{
    public interface IPaymentService
    {
        Task<bool> Process(PaymentInfoInputModel paymentInfoInput);
    }
}
