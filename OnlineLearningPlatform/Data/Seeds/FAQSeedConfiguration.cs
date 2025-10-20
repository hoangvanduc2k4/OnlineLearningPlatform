using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using OnlineLearningPlatform.Models.Entities.Others; // Đảm bảo namespace này chính xác
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
            var faqs = new List<FAQ>();

            // Một danh sách các cặp câu hỏi-trả lời để dễ quản lý
            var qaPairs = new Dictionary<string, string>
            {
                // Account & Profile
                { "How do I create an account?", "You can sign up by clicking the 'Register' button on the homepage and filling out the required information." },
                { "I forgot my password. How can I reset it?", "Click on the 'Forgot Password' link on the login page and follow the instructions sent to your email." },
                { "How can I change my email address?", "You can update your email address in the 'Account Settings' section of your profile." },
                { "How do I update my profile information?", "Navigate to your profile page and click 'Edit Profile' to update your personal details." },
                { "Can I delete my account?", "Yes, you can request account deletion from your account settings page. Please note this action is irreversible." },

                // Courses & Learning
                { "How do I enroll in a course?", "Simply navigate to the course page and click the 'Enroll Now' or 'Buy Now' button." },
                { "Are there any free courses available?", "Yes, we offer a selection of free courses. You can find them in the 'Free Courses' category." },
                { "Do I get a certificate upon course completion?", "Yes, a certificate of completion is awarded for most courses once you finish all the lessons and quizzes." },
                { "How can I track my learning progress?", "Your progress is automatically tracked and displayed on your student dashboard and within each course." },
                { "Is there a time limit to complete a course?", "Most courses offer lifetime access, so you can learn at your own pace without any deadlines." },
                { "Can I download course videos for offline viewing?", "This feature depends on the instructor's settings. Some courses allow video downloads via our mobile app." },
                { "Where can I find the materials for the course?", "All downloadable resources and materials are typically found in a 'Resources' tab within the course player." },
                { "How can I ask the instructor a question?", "You can use the Q&A section inside the course to ask questions directly to the instructor and other students." },
                { "Can I retake quizzes if I fail?", "Yes, in most cases, you can retake quizzes multiple times to improve your score." },
                
                // Payment & Billing
                { "What payment methods do you accept?", "We accept major credit cards, PayPal, and various local payment options depending on your region." },
                { "Is my payment information secure?", "Absolutely. We use industry-standard encryption and work with trusted payment gateways to protect your information." },
                { "Do you offer a refund policy?", "Yes, we have a 30-day money-back guarantee. You can request a refund from your purchase history page." },
                { "How do subscriptions work?", "A subscription gives you access to a library of courses for a monthly or yearly fee. You can cancel anytime." },
                { "Can I get an invoice for my purchase?", "Yes, invoices are automatically generated and can be accessed from your 'Purchase History' page." },
                { "How do I apply a discount code?", "You can enter your discount or coupon code at the checkout page before completing your payment." },
                { "My payment failed. What should I do?", "Please double-check your payment details or try a different payment method. If the issue persists, contact our support team." },
                { "Do you offer team or business plans?", "Yes, we have special plans for businesses. Please visit our 'For Business' page for more information." },
                { "Can I gift a course to someone?", "Yes, there is a 'Gift this Course' option on each course page." },

                // Technical Support
                { "The video is not playing. What should I do?", "Try clearing your browser cache, disabling ad-blockers, or using a different browser." },
                { "Is the platform compatible with my device?", "Our platform is web-based and works on most modern desktops, tablets, and smartphones." },
                { "Do you have a mobile app?", "Yes, our app is available for both iOS and Android devices for learning on the go." },
                { "How do I report a technical issue or a bug?", "Please use the 'Help' or 'Support' link on our website to contact our technical support team." },
                { "What are the system requirements for viewing courses?", "You need a stable internet connection and an up-to-date web browser like Chrome, Firefox, or Safari." },

                // Instructors
                { "How can I become an instructor on your platform?", "You can apply by visiting the 'Become an Instructor' page and submitting your application." },
                { "What are the requirements to be an instructor?", "We look for experts with a passion for teaching and the ability to create high-quality course content." },
                { "How does the revenue sharing for instructors work?", "Instructors earn a percentage of the revenue from their course sales. Detailed terms are provided during onboarding." },
                { "Who owns the rights to the course content I create?", "As an instructor, you retain the rights to your content. You grant us a license to host and sell it on our platform." },
                { "What tools do you provide to help me create a course?", "We offer resources, tutorials, and support to guide you through the course creation and marketing process." },

                // Community & Other
                { "Is there a community forum to connect with other students?", "Yes, many courses have dedicated discussion forums, and we also have a general community space." },
                { "How do I change the language of the platform?", "You can change the display language from the settings menu, usually located in the footer or your profile." },
                { "How can I contact customer support?", "You can reach our support team via the 'Contact Us' page or the live chat widget." },
                { "What is your privacy policy?", "You can review our full privacy policy by clicking the 'Privacy Policy' link in the website's footer." },
                { "Do you offer courses in different languages?", "Yes, our course library includes content in multiple languages. You can filter by language." },
                { "How are courses reviewed and rated?", "Students who have enrolled in a course can leave a rating and a written review to share their experience." },
                { "Can I suggest a topic for a new course?", "We'd love to hear your suggestions! Please submit them through our contact form." },
                { "How do I unsubscribe from marketing emails?", "You can unsubscribe by clicking the 'Unsubscribe' link at the bottom of any marketing email." },
                { "Are the courses accredited?", "While our certificates demonstrate your skills, they are not typically university-accredited unless specified on the course page." },
                { "How is the course content kept up-to-date?", "We encourage our instructors to regularly update their courses to keep the content fresh and relevant." },
                { "What is the 'wishlist' feature for?", "You can add courses to your wishlist to save them for later and get notified about sales." },
                { "Can I share my account with others?", "No, account sharing is against our terms of service. Each user must have their own account." },
                { "How do I find the best course for me?", "You can use our search and filter functions, read reviews, and watch preview lectures to find the perfect course." },
                { "What happens if an instructor leaves the platform?", "If you've already enrolled, you will retain access to the course content." },
                { "Do you have a referral program?", "Yes, we may offer a referral program. Check our promotions page for current offers." },
            };

            int id = 1;
            foreach (var pair in qaPairs)
            {
                var date = new DateTime(2025, 1, 1).AddDays(id - 1);
                faqs.Add(new FAQ
                {
                    FaqId = id,
                    Question = pair.Key,
                    Answer = pair.Value,
                    CreatedAt = date,
                    UpdatedAt = date,
                    CommonStatus = CommonStatus.Showed
                });
                id++;
            }

            return faqs;
        }
    }
}