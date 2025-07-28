using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZilckerEcho_Backend.Models
{
    public class Benefit
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Benefit name cannot be longer than 100 characters.")]
        public string Description { get; set; }
        [Required]
        public int TicketId { get; set; }
        [ForeignKey("TicketId")]
        public Ticket Ticket { get; set; }
    }
}
