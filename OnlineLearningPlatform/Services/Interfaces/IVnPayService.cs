using OnlineLearningPlatform.Models.ViewModels.VNPay;

namespace OnlineLearningPlatform.Services.Interfaces
{
    public interface IVnPayService
    {
        string CreatePaymentUrl(PaymentInformationModel model, HttpContext context);
        PaymentResponseModel PaymentExecute(IQueryCollection collections);

    }
}
