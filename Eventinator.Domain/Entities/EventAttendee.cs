namespace Eventinator.Domain.Entities
{
    public class EventAttendee : BaseEntity
    {
        public string UserId { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;
    }
}
