namespace Eventinator.Application.DTOs
{
    public class PaymentReadDTO : BaseAuditDTO
    {
        public string UserId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string Description { get; set; }
        public DateTime PaidAt { get; set; }
    }

    public class PaymentUpdateDTO : BaseAuditDTO
    {
        public string UserId { get; set; }
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
        public string UserId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string Description { get; set; }
        public DateTime PaidAt { get; set; }
    }
}
