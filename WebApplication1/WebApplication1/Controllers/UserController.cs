using AutoMapper;
using DeviceManagerBackend.Configurations;
using DeviceManagerBackend.Entities;
using DeviceManagerBackend.Models;
using DeviceManagerBackend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeviceManagerBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserService _userService;

       
        public UserController(UserService userService)
        {
            _userService = userService;
         
        }

        [HttpGet]
        public List<User> GetUsers()
        {  
            return _userService.GetUsers();
        }


        [HttpGet("{id}")]
        //[ProducesResponseType(typeof(UserProfile), 200)]
        public IActionResult GetUserById(int id)
        {
            var result = _userService.GetUserById(id);

            return Ok(result);
        }

        [HttpDelete("{id}")]

        public IActionResult DeleteUser(int id)
        {
            try
            {
                _userService.DeleteUser(id);
            }

            catch (Exception)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpPost]
        public IActionResult AddUser(UserDTO inputUser)
        {
            try
            {
                _userService.AddUser(inputUser);
                return Ok(inputUser);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
           
        }

        [HttpPatch("password/{id}")]

        public IActionResult UpdatePassword(UpdatePassword password, int id)
        {
            _userService.UpdatePassword(password, id);
            return Ok();
        }

        [HttpPatch("email/{id}")]

        public IActionResult UpdateEmail(UpdateEmail email, int id)
        {
            _userService.UpdateEmail(email, id);
            return Ok();
        }
    }
}
