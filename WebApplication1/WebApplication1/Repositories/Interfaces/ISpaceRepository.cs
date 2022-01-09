using DeviceManagerBackend.Entities;
using DeviceManagerBackend.Models;

namespace DeviceManagerBackend.Repositories.Interfaces
{
    public interface ISpaceRepository
    {
        public void CreateSpace(CreateSpace inputSpace);
        public void DeleteSpace(int id);
        public List<Space> GetSpaces();
        public SpaceModel GetSpaceById(int id);
    }
}
