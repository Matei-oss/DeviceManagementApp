using DeviceManagerBackend.Repositories;
using DeviceManagerBackend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeviceManagerBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        private AuthorizationService _authService;

        public AuthorizationController(AuthorizationService authService)
        {
            _authService = authService;
        }
        [HttpGet]
        public IActionResult Authenticate(string emailAddress, string password)
        {
            var token = _authService.AuthorizeUser(emailAddress, password);
            return Ok(token);
        }
    }
}
