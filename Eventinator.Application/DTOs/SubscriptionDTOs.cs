namespace Eventinator.Application.DTOs
{
    public class SubscriptionCreateDTO
    {
        public int UserId { get; set; }
        public int PlanId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
    }

    public class SubscriptionReadDTO : BaseAuditDTO
    {
        public int UserId { get; set; }
        public int PlanId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
    }

    public class SubscriptionUpdateDTO : BaseAuditDTO
    {
        public int UserId { get; set; }
        public int PlanId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
    }

    public class SubscriptionDeleteDTO : BaseDTO
    {
    }
}
