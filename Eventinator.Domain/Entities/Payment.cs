using System;

namespace Eventinator.Domain.Entities
{
    public class Payment : BaseEntity
    {
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string Description { get; set; }
        public DateTime PaidAt { get; set; }
        public ApplicationUser User { get; set; } = null!;
    }
}
