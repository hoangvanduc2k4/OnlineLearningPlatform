using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using OnlineLearningPlatform.Models.Entities.Others;
using OnlineLearningPlatform.Enums;

namespace OnlineLearningPlatform.Data.Seeds
{
    public class FAQSeedConfiguration : IEntityTypeConfiguration<FAQ>
    {
        public void Configure(EntityTypeBuilder<FAQ> builder)
        {
            builder.HasData(GetFaqs().ToArray());
        }

        private static List<FAQ> GetFaqs()
        {
            return new List<FAQ>
            {
                new FAQ
                {
                    FaqId = 1,
                    Question = "Làm thế nào để đăng ký tài khoản?",
                    Answer = "Bạn có thể nhấn vào nút Đăng ký trên trang chủ và điền đầy đủ thông tin yêu cầu.",
                    CreatedAt = DateTime.Parse("2025-01-01"),
                    UpdatedAt = DateTime.Parse("2025-01-01"),
                    CommonStatus = CommonStatus.Showed
                },
                new FAQ
                {
                    FaqId = 2,
                    Question = "Tôi có thể học các khóa học miễn phí không?",
                    Answer = "Một số khóa học được cung cấp miễn phí, bạn có thể tìm trong danh mục 'Khóa học miễn phí'.",
                    CreatedAt = DateTime.Parse("2025-01-02"),
                    UpdatedAt = DateTime.Parse("2025-01-02"),
                    CommonStatus = CommonStatus.Showed
                },
                new FAQ
                {
                    FaqId = 3,
                    Question = "Phương thức thanh toán nào được hỗ trợ?",
                    Answer = "Chúng tôi hỗ trợ thanh toán qua thẻ ngân hàng, ví điện tử và PayPal.",
                    CreatedAt = DateTime.Parse("2025-01-03"),
                    UpdatedAt = DateTime.Parse("2025-01-03"),
                    CommonStatus = CommonStatus.Showed
                },
                new FAQ
                {
                    FaqId = 4,
                    Question = "Làm thế nào để trở thành giảng viên?",
                    Answer = "Bạn có thể nộp đơn ứng tuyển Mentor trong mục 'Trở thành giảng viên'.",
                    CreatedAt = DateTime.Parse("2025-01-04"),
                    UpdatedAt = DateTime.Parse("2025-01-04"),
                    CommonStatus = CommonStatus.Showed
                },
                new FAQ
                {
                    FaqId = 5,
                    Question = "Tôi có thể học trên điện thoại không?",
                    Answer = "Có, nền tảng hỗ trợ cả trên web và ứng dụng di động.",
                    CreatedAt = DateTime.Parse("2025-01-05"),
                    UpdatedAt = DateTime.Parse("2025-01-05"),
                    CommonStatus = CommonStatus.Showed
                }
            };
        }
    }
}
