using System.Security.Cryptography;
using System.Text;
namespace OnlineLearningPlatform.Utils
{
    public static class VnPayUtils
    {
        public static string HmacSHA512(string key, string inputData)
        {
            var hash = new StringBuilder();
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            byte[] inputBytes = Encoding.UTF8.GetBytes(inputData);
            using (var hmac = new HMACSHA512(keyBytes))
            {
                byte[] hashValue = hmac.ComputeHash(inputBytes);
                foreach (var theByte in hashValue)
                {
                    hash.Append(theByte.ToString("x2"));
                }
            }
            return hash.ToString();
        }

        public static string GetIpAddress(HttpContext context)
        {
            var ipAddress = string.Empty;
            try
            {
                var remoteIpAddress = context.Connection.RemoteIpAddress;
                if (remoteIpAddress != null)
                {
                    ipAddress = remoteIpAddress.IsIPv4MappedToIPv6 ? remoteIpAddress.MapToIPv4().ToString() : remoteIpAddress.ToString();
                }
            }
            catch
            {
                ipAddress = "127.0.0.1";
            }
            return ipAddress;
        }

        public class VnPayCompare : IComparer<string>
        {
            public int Compare(string? x, string? y)
            {
                return string.Compare(x, y, StringComparison.Ordinal);
            }
        }
    }

}
