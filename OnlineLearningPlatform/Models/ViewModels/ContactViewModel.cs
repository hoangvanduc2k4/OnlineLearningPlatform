using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "Please enter your name.")]
        [Display(Name = "Your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [Display(Name = "Your Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter the subject.")]
        [Display(Name = "Subject")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Please enter the message.")]
        [Display(Name = "Message")]
        public string Message { get; set; }
    }
}