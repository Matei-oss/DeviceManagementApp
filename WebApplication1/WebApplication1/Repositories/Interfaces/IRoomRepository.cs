using DeviceManagerBackend.Entities;
using DeviceManagerBackend.Models;

namespace DeviceManagerBackend.Repositories.Interfaces
{
    public interface IRoomRepository
    {
        public Room GetRoomById(int id);
        public List<Room> GetRooms();
        public void AddRoom(Room inputRoom);
        public void DeleteRoom(int id);
    }
}
