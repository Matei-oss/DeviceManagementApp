using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DeviceManagerBackend.Models;
using DeviceManagerBackend.Services;
using DeviceManagerBackend.Attributes;
using DeviceManagerBackend.Entities;
using DeviceManagerBackend.Constants;

namespace DeviceManagerBackend.Controllers
{
    [Authorize(Role = Roles.Administrator)]
    [Route("api/[controller]")]
    [ApiController]
    public class DevicesController : ControllerBase
    {
        private DeviceService _deviceService;

        public DevicesController(DeviceService deviceService)
        {
            _deviceService = deviceService;
        }

        [HttpGet]
        public List<Device> GetDevices()
        {
            
            var devices = _deviceService.GetDevices();
            return devices;
        }

        [HttpGet("{id}")]

        public Device GetDeviceById(int id)
        {
            var device = _deviceService.GetDeviceById(id);
            return device;
        }

        [HttpPost]
        public IActionResult AddDevice(DeviceModel inputDevice)
        {
             _deviceService.CreateDevice(inputDevice);
            return Ok(inputDevice);

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDevice(int id)
        {
            
            try
            {
                _deviceService.DeleteDevice(id);
            }
            catch (Exception)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpPut("device/{deviceId}/room/{roomId}")]

        public IActionResult AssignDevice(int deviceId, int roomId)
        {
            _deviceService.AssignDevice(deviceId, roomId);
            return Ok();
        }

        //[HttpPatch("{id}")]

        //public IActionResult UpdateDevice(Device inputDevice,int id)
        //{
        //    _deviceService.UpdateDevice(inputDevice, id);
        //    return Ok();
        //}

       // [HttpPut("device/{deviceId}/room/{roomId}")]

    }
}
