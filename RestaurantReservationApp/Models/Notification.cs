using RestaurantReservationApp.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantReservationApp.Models;

public class Notification
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int NotificationId { get; set; }
    [ForeignKey("User")]
    public int UserId { get; set; }
    [Required]
    [StringLength(500)]
    public string? Message { get; set; }
    [Required]
    public NotificationType NotificationType { get; set; }
    public DateTime SentAt { get; set; } = DateTime.Now;

    public User? User { get; set; }
}
