using AutoMapper;
using DeviceManagerBackend.Entities;
using DeviceManagerBackend.Models;
using DeviceManagerBackend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DeviceManagerBackend.Repositories
{
    public class SpaceRepository : ISpaceRepository
    {
        private readonly ApplicationDbContext _context;

        private readonly IMapper _mapper;

        public SpaceRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void CreateSpace(CreateSpace inputSpace)
        {
            var spaceAdded = _mapper.Map<Space>(inputSpace);
            _context.Spaces.Add(spaceAdded);
            _context.SaveChanges();
        }

        public void DeleteSpace(int id)
        {
            var space = _context.Spaces.FirstOrDefault(x => x.Id == id);
            _context.Spaces.Remove(space);
            _context.SaveChanges();
        }

        public List<Space> GetSpaces()
        {
            return _context.Spaces.ToList();
        }

        public SpaceModel GetSpaceById(int id)
        {

            var returnedSpace = _context.Spaces.Include(x => x.Rooms).FirstOrDefault(x => x.Id ==id);

            var mappedSpace = _mapper.Map<SpaceModel>(returnedSpace);

            return mappedSpace;
        }

        public void UpdateSpace(UpdateSpace updateSpace, int id)
        {
            var spaceReturned = _context.Spaces.Include(x => x.Rooms).FirstOrDefault(x => x.Id == id);

            var spaceMapped = _mapper.Map<Space>(updateSpace);

            spaceReturned.Name = spaceMapped.Name;
            spaceReturned.Type = spaceMapped.Type;
            _context.SaveChanges();

        }
    }
}
