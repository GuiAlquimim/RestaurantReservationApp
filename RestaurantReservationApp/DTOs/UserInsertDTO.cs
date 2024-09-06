using RestaurantReservationApp.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace RestaurantReservationApp.DTOs;

public class UserInsertDTO
{
    [Required]
    [StringLength(100)]
    public string? Name { get; set; }

    [Required]
    [StringLength(100)]
    public string? Email { get; set; }

    [Required]
    [StringLength(100)]
    public string? Password { get; set; }

    [StringLength(11)]
    public string? PhoneNumber { get; set; }

    public Role Role { get; set; }
}
