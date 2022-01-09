using AutoMapper;
using DeviceManagerBackend.Entities;
using DeviceManagerBackend.Models;

namespace DeviceManagerBackend.Configurations
{
    public class MainProfile : Profile
    {
        public MainProfile()
        {
            CreateMap<User, UserProfile>()
                .ForMember(dest => dest.FullName,
                    opt => opt.MapFrom(src => src.FirstName + " " + src.LastName));
            //CreateMap<User, UserProfile>().ReverseMap();

            CreateMap<DeviceModel, Device>()
                .ForMember(dest => dest.Room, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<User, UpdatePassword>().ReverseMap();

            CreateMap<User, UpdateEmail>().ReverseMap();

            CreateMap<Room, CreateRoom>().ReverseMap();

            CreateMap<User, UserDTO>().ReverseMap();

            CreateMap<Device, UpdateDevice>().ReverseMap();
        }
    }
}
