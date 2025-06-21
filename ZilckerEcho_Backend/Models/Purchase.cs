using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZilckerEcho_Backend.Models
{
    public class Purchase
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Event name cannot be longer than 10 characters.")]
        public string Date { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Time cannot be longer than 5 characters.")]
        public string Time { get; set; }
        [Required]
        public bool Status { get; set; }    
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal TotalPrice { get; set;  }
        [Required]  
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        [Required]
        public int TicketId { get; set; }
        [ForeignKey("TicketId")]
        public Ticket Ticket { get; set; }
    }
}
