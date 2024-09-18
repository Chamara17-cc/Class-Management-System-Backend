using System.ComponentModel.DataAnnotations;

namespace Class_Management_System.Models
{
    public class UnitTestSubmission
    {
        [Key]
        public int UnitTestSubmissionId { get; set; }

        public string SubmissionUrl { get; set; }
        public DateTime SubmissionDate { get; set; }

        public Student Student { get; set; }
        public int StudentId { get; set; }

        public Unit Unit { get; set; }
        public int UnitId { get; set; }
    }
}
