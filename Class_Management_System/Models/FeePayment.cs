namespace Class_Management_System.Models
{
    public class FeePayment
    {
        public int FeePaymentId { get; set; }

        public decimal TotalPaid { get; set; }
        public decimal MonthlyPaid { get; set; }

        public Student Student { get; set; }
        public int StudentId { get; set; }
    }
}
