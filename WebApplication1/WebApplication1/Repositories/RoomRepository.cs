using DeviceManagerBackend.Repositories.Interfaces;
using DeviceManagerBackend.Models;
using DeviceManagerBackend.Repositories;
using DeviceManagerBackend.Repositories;
using DeviceManagerBackend.Entities;
using Microsoft.EntityFrameworkCore;

namespace DeviceManagerBackend.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly ApplicationDbContext _context;

        public RoomRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddRoom(Room inputRoom)
        {
            _context.Rooms.Add(inputRoom);
            _context.SaveChanges();
        }

        public void DeleteRoom(int id)
        {
            var device = _context.Rooms.FirstOrDefault(x => x.Id == id);
            _context.Rooms.Remove(device);
            _context.SaveChanges();
        }

        public Room GetRoomById(int id)
        {
            return _context.Rooms.Include(x => x.Devices).FirstOrDefault(x => x.Id == id);
        }

        public List<Room> GetRooms()
        {
            return _context.Rooms.ToList();
        }

    }
}
