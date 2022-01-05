using AutoMapper;
using DeviceManagerBackend.Entities;
using DeviceManagerBackend.Models;
using DeviceManagerBackend.Repositories.Interfaces;

namespace DeviceManagerBackend.Services
{
    public class UserService
    {
        public IUserRepository _userRepo;

        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepo = userRepository;
            _mapper = mapper;
        }

        public User GetUserByEmailAddress(string emailAddress)
        {
            return _userRepo.GetUserByEmailAddress(emailAddress);
        }

        public List<User> GetUsers()
        {
            return _userRepo.GetAllUsers();
        }

        public void AddUser(User inputUser)
        {
            _userRepo.AddUser(inputUser);
        }

        public void DeleteUser(int id)
        {
            _userRepo.DeleteUser(id);
        }

        public UserProfile GetUserById(int id)
        {
            var returnedUser = _userRepo.GetUserById(id);

            var mappedUser = _mapper.Map<UserProfile>(returnedUser);

            return mappedUser;
        }

        public void UpdatePassword(UpdatePassword password, int id)
        {
            var returnedUser = _userRepo.GetUserById(id);

            var mappedUser = _mapper.Map<UpdatePassword>(returnedUser);

            _userRepo.UpdatePassword(password, id);
        }

        public void UpdateEmail(UpdateEmail email, int id)
        {
            var returnedUser = _userRepo.GetUserById(id);

            var mappedUser = _mapper.Map<UpdateEmail>(returnedUser);

            _userRepo.UpdateEmail(email, id);
        }
    }
}
