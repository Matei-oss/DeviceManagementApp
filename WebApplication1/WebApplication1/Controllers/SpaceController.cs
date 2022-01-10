using DeviceManagerBackend.Entities;
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

        [HttpDelete("{id}")]
        public IActionResult DeleteSpace(int id)
        {
            try
            {
                _spaceService.DeleteSpace(id);
            }
            catch (Exception)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpGet]
        public List<Space> GetSpaces()
        {
            return _spaceService.GetSpaces();
        }

        [HttpGet("{id}")]

        public SpaceModel GetSpaceById(int id)
        {
            return _spaceService.GetSpaceById(id);
        }

        [HttpPatch("space/{id}")]
        public IActionResult UpdateSpace(UpdateSpace updateSpace, int id)
        {
            _spaceService.UpdateSpace(updateSpace, id);
            return Ok(updateSpace);
        }

        [HttpPut("space/{spaceId}/user/{userId}")]

        public IActionResult AssignSpace(int spaceId, int userId)
        {
            _spaceService.AssignSpace(spaceId, userId);
            return Ok();
        }
    }
}
