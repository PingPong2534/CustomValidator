using System.ComponentModel.DataAnnotations;

namespace CustomValidator.Infrastructure.ValidationAttributes
{
    public class RequiredAttribute : CustomizedValidationAttribute
    {
        public RequiredAttribute()
        {
            ErrorMessage = "Value cannot be null or empty.";
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
                return Error();

            if (value is string && string.IsNullOrEmpty(value as string))
                return Error();

            return Success();
        }
    }
}