using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform.Attributes
{
    public class FileValidate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null) return ValidationResult.Success;

            var file = value as IFormFile;

            if (file == null) return ValidationResult.Success;

            string[] validExtensions = { ".jpg", ".jpeg", ".png" };

            string fileExt = Path.GetExtension(file.FileName).ToLower();

            if (!validExtensions.Contains(fileExt))
            {
                return new ValidationResult("Chỉ cho phép file .jpg, .jpeg, .png");
            }

            
            if (file.Length > 5 * 1024 * 1024)
            {
                return new ValidationResult("Kích thước file tối đa 5MB");
            }

            return ValidationResult.Success;
        }
    }
}
