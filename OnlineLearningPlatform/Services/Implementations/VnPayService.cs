using Microsoft.Extensions.Options;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Enums;
using OnlineLearningPlatform.Models.Entities.CoursePart;
using OnlineLearningPlatform.Models.Entities.Others;
using OnlineLearningPlatform.Models.ViewModels;
using OnlineLearningPlatform.Services.Interfaces;
using OnlineLearningPlatform.Utils;
using System.Net;
using System.Text;

namespace OnlineLearningPlatform.Services.Implementations
{
    public class VnPayService : IVnPayService
    {
        private readonly VnPayConfig _config;
        private readonly OnlineLearningDBContext _context;
        private readonly ITransactionService _transactionService;
        private readonly ICourseEnrollmentService _courseEnrollmentService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public VnPayService(
            IOptions<VnPayConfig> config,
            OnlineLearningDBContext context,
            ITransactionService transactionService,
            ICourseEnrollmentService courseEnrollmentService,
            IHttpContextAccessor httpContextAccessor
        )
        {
            _config = config.Value;
            _context = context;
            _transactionService = transactionService;
            _courseEnrollmentService = courseEnrollmentService;
            _httpContextAccessor = httpContextAccessor;
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

            Console.WriteLine($"[DEBUG] SignData (Create): {signData}");

            string vnp_SecureHash = VnPayUtils.HmacSHA512(_config.HashSecret, signData);
            string paymentUrl = _config.BaseUrl + "?" + queryString + "&vnp_SecureHash=" + vnp_SecureHash;

            return paymentUrl;
        }

        public async Task<VnPaymentResponseModel> PaymentExecute(IQueryCollection collections)
        {
            var vnp_SecureHash = collections["vnp_SecureHash"].ToString();

            var vnpayData = new SortedDictionary<string, string>(new VnPayUtils.VnPayCompare());


            string rawQuery = _httpContextAccessor.HttpContext.Request.QueryString.Value;

            if (rawQuery.StartsWith("?"))
            {
                rawQuery = rawQuery.Substring(1);
            }

            string[] pairs = rawQuery.Split('&');
            foreach (string pair in pairs)
            {
                string[] kv = pair.Split('=');
                if (kv.Length != 2) continue;

                string key = kv[0];
                string value = kv[1];

                if (!string.IsNullOrEmpty(key) && key.StartsWith("vnp_"))
                {
                    if (key == "vnp_SecureHashType" || key == "vnp_SecureHash")
                    {
                        continue;
                    }
                    vnpayData.Add(key, value);
                }
            }

            var data = new StringBuilder();
            foreach (var (key, value) in vnpayData)
            {
                if (!string.IsNullOrEmpty(value))
                {
                    data.Append(key + "=" + value + "&");
                }
            }

            string signData = data.ToString().TrimEnd('&');

            Console.WriteLine($"[DEBUG] SignData (Callback): {signData}");

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
                TransactionHistory? transaction = await _transactionService.GetTransactionById(long.Parse(orderId));

                if (transaction == null)
                {
                    responseModel.OrderDescription = "Không tìm thấy giao dịch.";
                    return responseModel;
                }

                if (transaction.Status == TransactionStatus.Completed)
                {
                    responseModel.Success = true;
                    responseModel.OrderDescription = "Giao dịch đã được xử lý trước đó.";
                    return responseModel;
                }

                if (newSecureHash.Equals(vnp_SecureHash, StringComparison.InvariantCultureIgnoreCase) && vnPayResponseCode == "00")
                {
                    string courseName = transaction.Course?.CourseName ?? "Unknown Course";
                    string description = $"Successfully pay for Course: {courseName}";

                    transaction.Status = TransactionStatus.Completed;
                    transaction.Description = description.Length > 255 ? description.Substring(0, 252) + "..." : description;
                    transaction.ModifiedDate = DateTime.Now;

                    await _transactionService.UpdateTransactionAsync(transaction);

                    var isEnrolled = await _courseEnrollmentService.CheckCourseEnrollment(transaction.UserId, transaction.CourseId!.Value);
                    if (!isEnrolled)
                    {
                        var enrollment = new CourseEnrollment
                        {
                            UserId = transaction.UserId,
                            CourseId = transaction.CourseId!.Value,
                            DateCreated = DateTime.Now
                        };
                        await _courseEnrollmentService.AddCourseEnrollmmentAsync(enrollment);
                    }

                    responseModel.Success = true;
                }
                else
                {
                    transaction.Status = TransactionStatus.Failed;
                    transaction.Description = $"Failed. Error Code VNPay is: {vnPayResponseCode}. Hash check failed: {!newSecureHash.Equals(vnp_SecureHash, StringComparison.InvariantCultureIgnoreCase)}";
                    transaction.ModifiedDate = DateTime.Now;
                    await _transactionService.UpdateTransactionAsync(transaction);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"PaymentExecute Error: {ex.Message} \n {ex.StackTrace}");
                responseModel.OrderDescription = "Lỗi hệ thống khi xử lý giao dịch.";
            }

            return responseModel;
        }
    }
}