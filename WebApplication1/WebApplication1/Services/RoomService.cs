using DeviceManagerBackend.Models;
using DeviceManagerBackend.Repositories;
using Microsoft.EntityFrameworkCore;
using DeviceManagerBackend.Repositories.Interfaces;
using DeviceManagerBackend.Entities;

namespace DeviceManagerBackend.Services
{
    public class RoomService
    {
        public IRoomRepository _roomRepository;

        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public List<Room> GetRooms()
        {
            var roomsReturned = _roomRepository.GetRooms();
            return roomsReturned;
        }
        public Room GetRoomById(int id)
        {
            var roomReturned = _roomRepository.GetRoomById(id);
            return roomReturned;
        }
        public void CreateRoom(Room inputRoom)
        {
            _roomRepository.AddRoom(inputRoom);
        }

        public void DeleteRoom(int id)
        {
            _roomRepository.DeleteRoom(id);
        }
    }
}
