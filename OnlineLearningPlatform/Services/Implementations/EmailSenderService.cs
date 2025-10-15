using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using MimeKit;
using OnlineLearningPlatform.Utils;

namespace OnlineLearningPlatform.Services
{
    public class EmailSenderService : IEmailSender
    {


        private readonly EmailSettings _emailSettings;

        public EmailSenderService(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }


        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress(_emailSettings.FromName, _emailSettings.FromEmail));

            var emailList = email.Split(",");
            foreach (var e in emailList)
            {
                emailMessage.To.Add(new MailboxAddress("", e));
            }

            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = htmlMessage
            };

            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                // Connect tới SMTP server
                await client.ConnectAsync(_emailSettings.SmtpServer, _emailSettings.SmtpPort, MailKit.Security.SecureSocketOptions.StartTls);

                // Nếu Gmail: có thể cần disable XOAUTH2 hoặc gặp yêu cầu app password nếu bật 2FA
                await client.AuthenticateAsync(_emailSettings.FromEmail, _emailSettings.Password);

                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }

        }
    }
}
