using Microsoft.EntityFrameworkCore;
using RestaurantReservationApp.Data.Context;
using RestaurantReservationApp.Data.Interfaces;
using RestaurantReservationApp.Models;

namespace RestaurantReservationApp.Data.Respositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<User> GetUsers()
    {
        return _context.Users.AsNoTracking().ToList();
    }

    public User GetUserById(int id)
    {
        return _context.Users.AsNoTracking().FirstOrDefault(u => u.UserId == id);
    }
    public User GetUserByEmail(string email)
    {
        return _context.Users.AsNoTracking().FirstOrDefault(u => u.Email == email);
    }

    public User InsertUser(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();

        return user;
    }

    public User UpdateUser(User user)
    {
        _context.Entry(user).State = EntityState.Modified;
        _context.SaveChanges();

        return user;
    }

    public User DeleteUser(int id)
    {
        var user = _context.Users.FirstOrDefault(u => u.UserId == id);

        _context.Users.Remove(user);
        _context.SaveChanges();

        return user;
    }
}