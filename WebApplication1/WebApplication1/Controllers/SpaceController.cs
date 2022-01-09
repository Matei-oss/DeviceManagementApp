using DeviceManagerBackend.Models;
using DeviceManagerBackend.Services;
using Microsoft.AspNetCore.Mvc;

namespace DeviceManagerBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpaceController : ControllerBase
    {
        private SpaceService _spaceService;
        
        public SpaceController(SpaceService spaceService)
        {
            _spaceService = spaceService;
        }

        [HttpPost]
        public IActionResult CreateSpace(CreateSpace inputSpace)
        {
            _spaceService.CreateSpace(inputSpace);
            return Ok(inputSpace);
        }
    }
}
