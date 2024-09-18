using System.ComponentModel.DataAnnotations;

namespace Class_Management_System.Models
{
    public class Attendence
    {
        [Key]
        public int AttendanceId { get; set; }

        public int TotalAttendance { get; set; }
        public int MonthlyAttendance { get; set; }

        public Student Student { get; set; }
        public int StudentId { get; set; }
    }
}
