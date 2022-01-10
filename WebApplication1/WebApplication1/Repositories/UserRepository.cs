using DeviceManagerBackend.Models;
using DeviceManagerBackend.Repositories.Interfaces;
using DeviceManagerBackend.Repositories;
using DeviceManagerBackend.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace DeviceManagerBackend.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        private readonly IMapper _mapper;
        public UserRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;   
        }
        public User GetUserByEmailAddress(string emailAddress)
        {
            return _context.Users.Include(x => x.Spaces).FirstOrDefault(x => x.EmailAddress == emailAddress);
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.Include(x => x.Spaces).ToList();
        }

        public void DeleteUser(int id)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        public void AddUser(UserDTO inputUser)
        {
            var userEntity = GetUserByEmailAddress(inputUser.EmailAddress);

            var userEntityMapped = _mapper.Map<User>(inputUser);

            if (userEntity != null)
            {
                throw new Exception("User already exists!");
            }
            _context.Users.Add(userEntityMapped);
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
