using RestaurantReservationApp.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace RestaurantReservationApp.DTOs;

public class UserGetDTO
{
    public int UserId { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public Role Role { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
