using DeviceManagerBackend.Entities;
using DeviceManagerBackend.Models;

namespace DeviceManagerBackend.Repositories.Interfaces
{
    public interface IDeviceRepository
    {
        public Device GetDeviceById(int id);
        public List<Device> GetDevices(bool onlyUnassignedDevices);
        public void AddDevice(DeviceModel inputDevice);
        public void AssignDevice(int deviceId, int roomId);
        public void DeleteDevice(int id);
        public void UpdateDevice(UpdateDevice updateDevice, int id);
    }
}
