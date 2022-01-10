using AutoMapper;
using DeviceManagerBackend.Entities;
using DeviceManagerBackend.Models;
using DeviceManagerBackend.Repositories.Interfaces;

namespace DeviceManagerBackend.Services
{
    public class SpaceService
    {
        public ISpaceRepository _spaceRepository;

        private readonly IMapper _mapper;

        public SpaceService(ISpaceRepository spaceRepository, IMapper mapper)
        {
            _spaceRepository = spaceRepository;
            _mapper = mapper;
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

        public SpaceModel GetSpaceById(int id)
        {
            var space = _spaceRepository.GetSpaceById(id);

            var mappedSpace = _mapper.Map<SpaceModel>(space);

            return mappedSpace;
        }

        public void UpdateSpace(UpdateSpace updateSpace, int id)
        {
            _spaceRepository.UpdateSpace(updateSpace, id);
        }
    }
}
