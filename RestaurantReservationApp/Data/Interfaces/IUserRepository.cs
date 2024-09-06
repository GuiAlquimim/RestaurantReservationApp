using RestaurantReservationApp.Models;

namespace RestaurantReservationApp.Data.Interfaces;

public interface IUserRepository
{
    public IEnumerable<User> GetUsers();
    public User GetUserById(int id);
    public User InsertUser(User user);
    public User UpdateUser(User user);
    public User DeleteUser(int id);
    public User GetUserByEmail(string email);
}
