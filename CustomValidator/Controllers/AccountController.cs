using CustomValidator.Infrastructure.Attributes;
using CustomValidator.Models.Request;
using CustomValidator.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace CustomValidator.Controllers
{
    [ValidateModel]
    [ApiController]
    [Route("[controller]/[action]")]
    public class AccountController : ControllerBase
    {
        [HttpPost]
        public UserLoginRes Login(UserLoginReq req)
        {
            return new UserLoginRes() { Authtoken = Guid.NewGuid().ToString() };
        }
    }
}
