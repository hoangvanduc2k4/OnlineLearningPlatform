using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using OnlineLearningPlatform.Models;

namespace OnlineLearningPlatform.Controllers
{
    public class ContactController : Controller
    {
        private readonly IEmailSender _emailSender;

        public ContactController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var recipientEmail = "nguyenhoangson07122004@gmail.com";
                    var subject = $"Contact message from {model.Name}: {model.Subject}";

                    var messageBody = $@"
                        <h3>You have a new message from the contact page:</h3>
                        <p><b>Sender's Name:</b> {model.Name}</p>
                        <p><b>Sender's Email:</b> {model.Email}</p>
                        <hr>
                        <p><b>Message:</b></p>
                        <p>{model.Message.Replace("\n", "<br>")}</p>";

                    await _emailSender.SendEmailAsync(recipientEmail, subject, messageBody);

                    ViewBag.StatusMessage = "Success: Your message has been sent successfully. Thank you!";

                    ModelState.Clear();
                    return View();
                }
                catch (Exception ex)
                {
                    ViewBag.StatusMessage = $"Error: An error occurred while sending the message. Please try again. ({ex.Message})";
                }
            }
            return View(model);
        }
    }
}