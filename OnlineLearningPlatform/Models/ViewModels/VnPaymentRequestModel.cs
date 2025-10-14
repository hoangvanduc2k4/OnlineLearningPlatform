namespace OnlineLearningPlatform.Models.ViewModels
{
    public class VnPaymentRequestModel
    {
        public int OrderId { get; set; }
        public string Description { get; set; } = string.Empty;
        public double Amount { get; set; }

    }
}
