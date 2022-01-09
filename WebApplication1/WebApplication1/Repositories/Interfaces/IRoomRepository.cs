using DeviceManagerBackend.Entities;
using DeviceManagerBackend.Models;

namespace DeviceManagerBackend.Repositories.Interfaces
{
    public interface IRoomRepository
    {
        public Room GetRoomById(int id);
        public List<Room> GetRooms();
        public void AddRoom(CreateRoom inputRoom);
        public void DeleteRoom(int id);
        public void AssignCapacity(int id, int capacity);
        public void UpdateRoom(UpdateRoom updateRoom, int id);  
    }
}
