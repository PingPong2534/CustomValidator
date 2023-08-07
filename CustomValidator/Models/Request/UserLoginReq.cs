using CustomValidator.Infrastructure.ValidationAttributes;

namespace CustomValidator.Models.Request
{
    public class UserLoginReq
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
