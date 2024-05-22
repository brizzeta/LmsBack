using System.ComponentModel.DataAnnotations;

namespace LmsBack.Annotations {
    public class FutureDateAttribute : ValidationAttribute {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
            if ((DateTime)value > DateTime.Now && value != null) return new ValidationResult(ErrorMessage);
            return ValidationResult.Success!;
        }
    }
}