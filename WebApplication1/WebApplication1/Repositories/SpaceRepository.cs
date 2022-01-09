using AutoMapper;
using DeviceManagerBackend.Entities;
using DeviceManagerBackend.Models;
using DeviceManagerBackend.Repositories.Interfaces;

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
    }
}
