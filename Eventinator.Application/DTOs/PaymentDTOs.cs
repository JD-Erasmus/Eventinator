namespace Eventinator.Application.DTOs
{
    public class PaymentReadDTO : BaseAuditDTO
    {
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string Description { get; set; }
        public DateTime PaidAt { get; set; }
    }

    public class PaymentUpdateDTO : BaseAuditDTO
    {
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string Description { get; set; }
        public DateTime PaidAt { get; set; }
    }

    public class PaymentDeleteDTO : BaseDTO
    {
    }

    public class PaymentCreateDTO
    {
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string Description { get; set; }
        public DateTime PaidAt { get; set; }
    }
}
