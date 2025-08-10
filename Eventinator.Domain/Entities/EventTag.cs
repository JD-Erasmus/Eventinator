namespace Eventinator.Domain.Entities
{
    public class EventTag : BaseEntity
    {
        public int EventId { get; set; }
        public int TagId { get; set; }
        public Event Event { get; set; } = null!;
        public Tag Tag { get; set; } = null!;
    }
}
