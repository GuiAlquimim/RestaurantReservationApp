using AutoMapper;
using RestaurantReservationApp.DTOs;
using RestaurantReservationApp.Models;

namespace RestaurantReservationApp.Mappings;

public class ProfilesDTO : Profile
{
    public ProfilesDTO()
    {
        CreateMap<User, UserGetDTO>().ReverseMap();
        CreateMap<UserInsertDTO, User>().ReverseMap();
        CreateMap<UserUpdateDTO, User>().ReverseMap();
    }
}
