using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace CustomValidator.Infrastructure.Extensions
{
    public static class ValidationExtension
    {
        public static string ErrorObj(this ValidationResult validationResult, object obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.Indented);
        }
    }
}
