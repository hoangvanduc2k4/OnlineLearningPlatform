using System.Net;
using System.Text;
using Microsoft.Extensions.Options;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Enums;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.Entities.Others;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Repositories.Interfaces;
using OnlineLearningPlatform.Services.Interfaces;
using OnlineLearningPlatform.Utils;

namespace OnlineLearningPlatform.Services.Implementations
{
    public class VnPayService : IVnPayService
    {
        private readonly VnPayConfig _config;
        private readonly OnlineLearningDBContext _context;
        private readonly ITransactionRepository _transactionRepository;
        private readonly ICourseEnrollmentRepository _courseEnrollmentRepository;

        public VnPayService(IOptions<VnPayConfig> config, OnlineLearningDBContext context, ITransactionRepository transactionRepository, ICourseEnrollmentRepository courseEnrollmentRepository)
        {
            _config = config.Value;
            _context = context;
            _transactionRepository = transactionRepository;
            _courseEnrollmentRepository = courseEnrollmentRepository;
        }

        public string CreatePaymentUrl(HttpContext context, VnPaymentRequestModel model)
        {
            var createDate = DateTime.Now;
            var vnpay = new SortedDictionary<string, string>(new VnPayUtils.VnPayCompare());
            vnpay.Add("vnp_Version", _config.Version);
            vnpay.Add("vnp_Command", _config.Command);
            vnpay.Add("vnp_TmnCode", _config.TmnCode);
            vnpay.Add("vnp_Amount", ((long)(model.Amount * 100)).ToString());
            vnpay.Add("vnp_CreateDate", createDate.ToString("yyyyMMddHHmmss"));
            vnpay.Add("vnp_CurrCode", _config.CurrCode);
            vnpay.Add("vnp_IpAddr", VnPayUtils.GetIpAddress(context));
            vnpay.Add("vnp_Locale", _config.Locale);
            vnpay.Add("vnp_OrderInfo", model.Description);
            vnpay.Add("vnp_OrderType", "other");
            vnpay.Add("vnp_ReturnUrl", _config.ReturnUrl);
            vnpay.Add("vnp_TxnRef", model.OrderId.ToString());

            var data = new StringBuilder();
            foreach (var (key, value) in vnpay)
            {
                if (!string.IsNullOrEmpty(value))
                {
                    data.Append(WebUtility.UrlEncode(key) + "=" + WebUtility.UrlEncode(value) + "&");
                }
            }
            string queryString = data.ToString().TrimEnd('&');
            string signData = queryString;
            string vnp_SecureHash = VnPayUtils.HmacSHA512(_config.HashSecret, signData);
            string paymentUrl = _config.BaseUrl + "?" + queryString + "&vnp_SecureHash=" + vnp_SecureHash;

            return paymentUrl;
        }

        public async Task<VnPaymentResponseModel> PaymentExecute(IQueryCollection collections)
        {
            var vnp_SecureHash = collections["vnp_SecureHash"].ToString();
            var vnpayData = new SortedDictionary<string, string>(new VnPayUtils.VnPayCompare());

            foreach (var (key, value) in collections)
            {
                if (!string.IsNullOrEmpty(key) && key.StartsWith("vnp_") && key != "vnp_SecureHashType" && key != "vnp_SecureHash")
                {
                    vnpayData.Add(key, value.ToString());
                }
            }

            var data = new StringBuilder();
            foreach (var (key, value) in vnpayData)
            {
                if (!string.IsNullOrEmpty(value))
                {
                    data.Append(WebUtility.UrlEncode(key) + "=" + WebUtility.UrlEncode(value) + "&");
                }
            }
            string signData = data.ToString().TrimEnd('&');
            string newSecureHash = VnPayUtils.HmacSHA512(_config.HashSecret, signData);

            var vnPayResponseCode = collections["vnp_ResponseCode"].ToString();
            var orderId = collections["vnp_TxnRef"].ToString();

            var responseModel = new VnPaymentResponseModel
            {
                Success = false,
                OrderId = orderId,
                TransactionId = collections["vnp_TransactionNo"].ToString(),
                Token = vnp_SecureHash,
                VnPayResponseCode = vnPayResponseCode,
                OrderDescription = collections["vnp_OrderInfo"].ToString(),
                PaymentMethod = collections["vnp_BankCode"].ToString(),
                Amount = Convert.ToInt64(collections["vnp_Amount"]) / 100
            };

            try
            {
                TransactionHistory? transaction = await _transactionRepository.GetByIdAsync(long.Parse(orderId));

                if (transaction != null)
                {
                    if (newSecureHash.Equals(vnp_SecureHash, StringComparison.InvariantCultureIgnoreCase) && vnPayResponseCode == "00")
                    {
                        transaction.Status = TransactionStatus.Completed;
                        transaction.Description = $"Successfully pay for Course: {transaction?.Course?.CourseName}";

                        var enrollment = new CourseEnrollment
                        {
                            UserId = transaction.UserId,
                            CourseId = (int)transaction.CourseId!,
                            DateCreated = DateTime.Now
                        };
                        await _courseEnrollmentRepository.AddAsync(enrollment);
                        responseModel.Success = true;
                    }
                    else
                    {
                        transaction.Status = TransactionStatus.Failed;
                        transaction.Description = $"Failed. Error Code VNPay is: {vnPayResponseCode}";
                        await _transactionRepository.UpdateAsync(transaction);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return responseModel;
        }
    }
}
