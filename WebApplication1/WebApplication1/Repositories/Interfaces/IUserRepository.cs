using DeviceManagerBackend.Entities;
using DeviceManagerBackend.Models;

namespace DeviceManagerBackend.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public List<User> GetAllUsers();
        public User GetUserByEmailAddress(string emailAddress);
        public User GetUserById(int id);
        public void DeleteUser(int id);
        public void AddUser(UserDTO inputUser);

        public void UpdatePassword(UpdatePassword inputUser, int id);

        public void UpdateEmail(UpdateEmail email, int id);

    }
}
