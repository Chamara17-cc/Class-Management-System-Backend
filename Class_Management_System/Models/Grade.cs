using System.ComponentModel.DataAnnotations;

namespace Class_Management_System.Models
{
    public class Grade
    {
        [Key]
        public int GradeId { get; set; }
        public int GradeNumber { get; set; }

        public ICollection<Unit> Units { get; set; }
    }
}
