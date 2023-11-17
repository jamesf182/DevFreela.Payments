using DevFreela.Paymentes.API.Models;
using DevFreela.Paymentes.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.Paymentes.API.Controllers
{
    [Route("api/payments")]
    public class PaymentsController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentsController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PaymentInfoInputModel paymentInfoInputModel)
        {
            var result = await _paymentService.Process(paymentInfoInputModel);

            if (!result)
            {
                return BadRequest();
            }

            return NoContent();
        }
    }
}
