using Microsoft.AspNetCore.Mvc;
using OnlineLearningPlatform.Services.Interfaces;

namespace OnlineLearningPlatform.Controllers
{
    public class PaymentController : Controller
    {
        private readonly IVnPayService _vnPayService;

        public PaymentController(IVnPayService vnPayService)
        {
            _vnPayService = vnPayService;
        }

        public async Task<IActionResult> PaymentResult()
        {
            var response = await _vnPayService.PaymentExecute(Request.Query);
            return View(response);
        }

    }
}
