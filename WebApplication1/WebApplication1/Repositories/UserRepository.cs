using DeviceManagerBackend.Models;
using DeviceManagerBackend.Repositories.Interfaces;
using DeviceManagerBackend.Repositories;
using DeviceManagerBackend.Entities;
using AutoMapper;

namespace DeviceManagerBackend.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

       
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public User GetUserByEmailAddress(string emailAddress)
        {
            return _context.Users.FirstOrDefault(x => x.EmailAddress == emailAddress);
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public void DeleteUser(int id)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        public void AddUser(User inputUser)
        {
            _context.Users.Add(inputUser);
            _context.SaveChanges();
        }

        public User GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        public void UpdatePassword(UpdatePassword password, int id)
        {
            var updatedUser = GetUserById(id);

            updatedUser.Password = password.Password;

            _context.SaveChanges();

        }

        public void UpdateEmail(UpdateEmail email, int id)
        {
            var updatedUser = GetUserById(id);

            updatedUser.EmailAddress = email.EmailAddress;

            _context.SaveChanges();
        }
    }
}
