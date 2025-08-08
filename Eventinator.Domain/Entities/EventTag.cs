namespace Eventinator.Domain.Entities
{
    public class EventTag : BaseEntity
    {
        public int EventId { get; set; }
        public int TagId { get; set; }
    }
}
