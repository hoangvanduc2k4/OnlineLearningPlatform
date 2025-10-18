namespace OnlineLearningPlatform.Models.ViewModels
{
    public class VnPaymentRequestModel
    {
        public long OrderId { get; set; }
        public string Description { get; set; } = string.Empty;
        public double Amount { get; set; }

    }
}
