using DeviceManagerBackend.Models;
using DeviceManagerBackend.Repositories;
using Microsoft.EntityFrameworkCore;
using DeviceManagerBackend.Repositories.Interfaces;
using DeviceManagerBackend.Entities;
using AutoMapper;

namespace DeviceManagerBackend.Services
{
    public class DeviceService
    {
        public IDeviceRepository _deviceRepository;

        private readonly IMapper _mapper;


        public DeviceService(IDeviceRepository deviceRepository)
        {
            _deviceRepository = deviceRepository;
        }

        public List<Device> GetDevices(bool onlyUnassignedDevices)
        {
            var devicesReturned = _deviceRepository.GetDevices(onlyUnassignedDevices);
            return devicesReturned;
        }
        public Device GetDeviceById(int id)
        {
            var deviceReturned = _deviceRepository.GetDeviceById(id);
            return deviceReturned;
        }
        public void CreateDevice(DeviceModel inputDevice)
        {
            _deviceRepository.AddDevice(inputDevice);
        }

        public void DeleteDevice(int id)
        {
            //var device = _deviceRepository.FirstOrDefault(x => x.Id == id);
            _deviceRepository.DeleteDevice(id);
            //_deviceRepository.SaveChangesAsync()
        }

        public void AssignDevice(int deviceId, int roomId)
        {
            _deviceRepository.AssignDevice(deviceId, roomId);
        }

        public void UpdateDevice(UpdateDevice updateDevice, int id)
        {
            _deviceRepository.UpdateDevice(updateDevice, id);
        }
    }
}
