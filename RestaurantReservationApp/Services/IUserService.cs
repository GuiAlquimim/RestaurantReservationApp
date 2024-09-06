using RestaurantReservationApp.DTOs;
using RestaurantReservationApp.Models;

namespace RestaurantReservationApp.Services;

public interface IUserService
{
    public IEnumerable<User> GetUsers();
    public IEnumerable<UserGetDTO> GetUsersDTO();
    public UserGetDTO GetUserByIdDTO(int id);   
    public UserGetDTO GetUserByEmail(string email);
    public User InsertUser(UserInsertDTO userInsertDTO);
    public User UpdateUser(UserUpdateDTO userUpdateDTO);
    public User DeleteUser(int id);
}
