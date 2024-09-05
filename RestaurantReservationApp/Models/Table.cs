using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantReservationApp.Models;

public class Table
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TableId { get; set; }
    [Required]
    public int Capacity { get; set; }
    [Required]
    public bool IsAvailable { get; set; }
}
