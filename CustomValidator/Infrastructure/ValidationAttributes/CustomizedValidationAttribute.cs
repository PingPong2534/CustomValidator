using CustomValidator.Models.Response;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace CustomValidator.Infrastructure.ValidationAttributes
{
    public class CustomizedValidationAttribute : ValidationAttribute
    {
        public string ErrorCode { get; set; }

        public ValidationResult Error()
        {
            var jsonError = JsonConvert.SerializeObject(new ErrorModel()
            {
                ErrorCode = ErrorCode,
                ErrorMessage = ErrorMessage
            });

            return new ValidationResult(jsonError);
        }

        public ValidationResult Success() => ValidationResult.Success;
    }
}