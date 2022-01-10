using DeviceManagerBackend.Repositories.Interfaces;
using DeviceManagerBackend.Models;
using DeviceManagerBackend.Repositories;
using DeviceManagerBackend.Repositories;
using DeviceManagerBackend.Entities;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace DeviceManagerBackend.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly ApplicationDbContext _context;

        private readonly IMapper _mapper;

        private readonly ISpaceRepository _spaceRepository;
        public RoomRepository(ApplicationDbContext context, IMapper mapper, ISpaceRepository spaceRepository)
        {
            _context = context;
            _mapper = mapper;
            _spaceRepository = spaceRepository;
        }

        public void AddRoom(CreateRoom inputRoom)
        {
            var roomAdded = _mapper.Map<Room>(inputRoom);
            _context.Rooms.Add(roomAdded);
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

        public void AssignCapacity(int id, int capacity)
        {
            var room = GetRoomById(id);

            room.Capacity = capacity;
            _context.SaveChanges();
        }

        public void UpdateRoom(UpdateRoom updateRoom, int id)
        {
            var roomReturned = GetRoomById(id);

            var roomMapped = _mapper.Map<Room>(updateRoom);

            roomReturned.Name = roomMapped.Name;
            roomReturned.Type = roomMapped.Type;
            roomReturned.Capacity = roomMapped.Capacity;

            _context.SaveChanges();
        }

        public void AssignRoom(int roomId, int spaceId)
        {
            var room = GetRoomById(roomId);
            var space = _spaceRepository.GetSpaceById(spaceId);


            space.Rooms.Add(room);
            room.Space = space;
            _context.SaveChanges();
        }
    }
}
