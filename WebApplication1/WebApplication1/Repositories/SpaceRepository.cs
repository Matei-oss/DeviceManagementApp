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
    }
}
