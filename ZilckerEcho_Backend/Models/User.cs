using System.ComponentModel.DataAnnotations;

namespace ZilckerEcho_Backend.Models
{
    public class User
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "Name cannot be longer than 60 characters.")]
        public string Name { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "Lastname cannot be longer than 60 characters.")]
        public string Lastname { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [StringLength(30, ErrorMessage = "Email cannot be longer than 100 characters.")]
        public string Email { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Password cannot be longer than 20 characters.")]
        public string Password { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Phone number cannot be longer than 15 characters.")]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Birthdate cannot be longer than 10 characters.")]
        public string Birthdate { get; set; }
    }
}
