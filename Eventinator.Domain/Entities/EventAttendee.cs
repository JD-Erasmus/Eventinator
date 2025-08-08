namespace Eventinator.Domain.Entities
{
    public class EventAttendee : BaseEntity
    {
        public int UserId { get; set; }
        public int EventId { get; set; }
    }
}
