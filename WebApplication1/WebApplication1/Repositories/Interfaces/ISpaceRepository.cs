using DeviceManagerBackend.Entities;
using DeviceManagerBackend.Models;

namespace DeviceManagerBackend.Repositories.Interfaces
{
    public interface ISpaceRepository
    {
        public void CreateSpace(CreateSpace inputSpace);
        public void DeleteSpace(int id);
        public List<Space> GetSpaces();
        public Space GetSpaceById(int id);
        public void UpdateSpace(UpdateSpace updateSpace, int id);
    }
}
