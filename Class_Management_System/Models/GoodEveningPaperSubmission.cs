using System.ComponentModel.DataAnnotations;

namespace Class_Management_System.Models
{
    public class GoodEveningPaperSubmission
    {
        [Key]
        public int GoodEveningPaperSubmissionId { get; set; }

        public string SubmissionUrl { get; set; }
        public DateTime SubmissionDate { get; set; }

        public Student Student { get; set; }
        public int StudentId { get; set; }
    }
}
