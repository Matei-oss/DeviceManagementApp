using DeviceManagerBackend.Entities;
using DeviceManagerBackend.Models;
using DeviceManagerBackend.Repositories.Interfaces;

namespace DeviceManagerBackend.Services
{
    public class SpaceService
    {
        public ISpaceRepository _spaceRepository;

        public SpaceService(ISpaceRepository spaceRepository)
        {
            _spaceRepository = spaceRepository;
        }

        public void CreateSpace(CreateSpace inputSpace)
        {
            _spaceRepository.CreateSpace(inputSpace);
        }

        public void DeleteSpace(int id)
        {
            _spaceRepository.DeleteSpace(id);
        }

        public List<Space> GetSpaces()
        {
           return  _spaceRepository.GetSpaces();
        }
    }
}
