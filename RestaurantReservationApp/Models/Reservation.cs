using RestaurantReservationApp.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantReservationApp.Models;

public class Reservation
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ReservationId { get; set; }
    [ForeignKey("User")]
    public int UserId { get; set; }
    [ForeignKey("Table")]
    public int TableId { get; set; }
    [Required]
    public DateTime ReservationDate { get; set; }
    [Required]
    public int PartySize { get; set; }
    public ReservationStatus Status { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; }

    public User? User { get; set; }
    public Table? Table { get; set; }
}
