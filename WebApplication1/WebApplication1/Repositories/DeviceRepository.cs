using DeviceManagerBackend.Repositories.Interfaces;
using DeviceManagerBackend.Models;
using DeviceManagerBackend.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace DeviceManagerBackend.Repositories
{
    public class DeviceRepository : IDeviceRepository
    {
        private readonly ApplicationDbContext _context;

        private readonly IMapper _mapper;

        private readonly IRoomRepository _roomRepository;
        public DeviceRepository(ApplicationDbContext context, IRoomRepository roomRepository, IMapper mapper)
        {
            _context = context;
            _roomRepository = roomRepository;
            _mapper = mapper;
        }
        
        public void AddDevice(DeviceModel inputDevice)
        {
            var newDevice = _mapper.Map<Device>(inputDevice);
            _context.Devices.Add(newDevice);
            _context.SaveChanges(); 
        }

        public void DeleteDevice(int id)
        {
            var device = _context.Devices.FirstOrDefault(x => x.Id == id);
            _context.Devices.Remove(device);
            _context.SaveChanges();
        }

        public Device GetDeviceById(int id)
        {
            return _context.Devices.Include(x => x.Room).FirstOrDefault(x =>x.Id == id);
        }

        public List<Device> GetDevices()
        {
            return _context.Devices.ToList();
        }

        public void AssignDevice(int deviceId, int roomId)
        {
            var room = _roomRepository.GetRoomById(roomId);
            var device = GetDeviceById(deviceId);

            room.Devices.Add(device);
            device.Room = room;
            _context.SaveChanges();
        }

        //public void UpdateDevice(Device inputDevice, int id)
        //{
        //    var device = _context.Devices.FirstOrDefault(x => x.Id == id);
        //    _context.Update(inputDevice);
        //    _context.SaveChanges();
        //}
    }
}
