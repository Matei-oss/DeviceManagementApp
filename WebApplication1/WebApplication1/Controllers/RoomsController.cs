using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DeviceManagerBackend.Models;
using DeviceManagerBackend.Services;
using DeviceManagerBackend.Services;
using DeviceManagerBackend.Entities;

namespace DeviceManagerBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private RoomService _roomService;

        public RoomsController(RoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public List<Room> GetRooms()
        {
            var rooms = _roomService.GetRooms();
            return rooms;
        }

        [HttpGet("id")]
        public Room GetRoomById(int id)
        {
            var room = _roomService.GetRoomById(id);
            return room;
        }

        [HttpPost]
        public IActionResult AddRoom(CreateRoom inputRoom)
        {
            _roomService.CreateRoom(inputRoom);
            return Ok(inputRoom);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(int id)
        {

            try
            {
                _roomService.DeleteRoom(id);
            }
            catch (Exception)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpPatch("room/{id}/capacity/{capacity}")]
        public IActionResult AssignCapacity(int id, int capacity)
        {
            _roomService.AssignCapacity(id, capacity);
            return Ok();
        }
    }
}
