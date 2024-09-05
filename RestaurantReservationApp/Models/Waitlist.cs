using RestaurantReservationApp.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantReservationApp.Models;

public class Waitlist
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int WaitlistId { get; set; }
    [ForeignKey("User")]
    public int UserId { get; set; }
    [Required]
    public int PartySize { get; set; }
    public DateTime RequestedTime { get; set; }
    [Required]
    public WaitlistStatus Status { get; set; }
    public DateTime CreatedAt { get; set; }

    public User? User { get; set; }
}
