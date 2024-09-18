using System.ComponentModel.DataAnnotations;

namespace Class_Management_System.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(20)]
        public string WhatsappNumber { get; set; }

        [Required]
        [MaxLength(20)]
        public string ParentPhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string School { get; set; }

        [Required]
        public int Grade { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

        public ICollection<UnitTestSubmission> UnitTestSubmissions { get; set; }
        public ICollection<TermTestSubmission> TermTestSubmissions { get; set; }
        public ICollection<GoodEveningPaperSubmission> GoodEveningPaperSubmissions { get; set; }
        public ICollection<PastPaperSubmission> PastPaperSubmissions { get; set; }

        public Attendence Attendance { get; set; }
        public FeePayment FeePayment { get; set; }
    }
}
