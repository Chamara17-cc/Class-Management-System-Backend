using System.ComponentModel.DataAnnotations;

namespace Class_Management_System.Models
{
    public class TermTestSubmission
    {
        [Key]
        public int TermTestSubmissionId { get; set; }

        public string SubmissionUrl { get; set; }
        public DateTime SubmissionDate { get; set; }

        public Student Student { get; set; }
        public int StudentId { get; set; }

        public string Term { get; set; } // First Term, Second Term, Third Term
    }
}
