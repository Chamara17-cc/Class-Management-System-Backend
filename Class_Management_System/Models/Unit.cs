using System.ComponentModel.DataAnnotations;

namespace Class_Management_System.Models
{
    public class Unit
    {
        [Key]
        public int UnitId { get; set; }

        [Required]
        public string UnitName { get; set; }

        public string UnitPaperPdfUrl { get; set; }
        public string YoutubeResourceLink { get; set; }
        public string UnitImagePdfUrl { get; set; }

        public Grade Grade { get; set; }
        public int GradeId { get; set; }
    }
}
