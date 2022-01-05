using DeviceManagerBackend.Entities;
using DeviceManagerBackend.Models;

namespace DeviceManagerBackend.Repositories.Interfaces
{
    public interface IDeviceRepository
    {
        public Device GetDeviceById(int id);
        public List<Device> GetDevices();
        public void AddDevice(DeviceModel inputDevice);
        //public void UpdateDevice(Device inputDevice, int id);
        public void AssignDevice(int deviceId, int roomId);
        public void DeleteDevice(int id);
    }
}
