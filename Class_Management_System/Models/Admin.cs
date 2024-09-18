using System.ComponentModel.DataAnnotations;

namespace Class_Management_System.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(100)]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
