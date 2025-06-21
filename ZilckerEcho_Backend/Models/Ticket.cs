using System.ComponentModel.DataAnnotations;

namespace ZilckerEcho_Backend.Models
{
    public class Ticket
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Name cannot be longer than 30 characters.")]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; } 

    }
}
