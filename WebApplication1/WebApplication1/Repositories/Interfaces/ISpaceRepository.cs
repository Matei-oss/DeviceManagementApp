using DeviceManagerBackend.Models;

namespace DeviceManagerBackend.Repositories.Interfaces
{
    public interface ISpaceRepository
    {
        public void CreateSpace(CreateSpace inputSpace);
    }
}
