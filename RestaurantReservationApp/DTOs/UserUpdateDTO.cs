using RestaurantReservationApp.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantReservationApp.DTOs;

public class UserUpdateDTO
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int UserId { get; set; }

    [Required]
    [StringLength(100)]
    public string? Name { get; set; }

    [Required]
    [StringLength(100)]
    public string? Email { get; set; }

    [StringLength(11)]
    public string? PhoneNumber { get; set; }

    public Role Role { get; set; }
}