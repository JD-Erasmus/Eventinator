namespace Eventinator.Application.DTOs
{
    public class EventTagReadDTO : BaseAuditDTO
    {
        public int EventId { get; set; }
        public int TagId { get; set; }
    }

    public class EventTagUpdateDTO : BaseAuditDTO
    {
        public int EventId { get; set; }
        public int TagId { get; set; }
    }

    public class EventTagDeleteDTO : BaseDTO
    {
    }

    public class EventTagCreateDTO
    {
        public int EventId { get; set; }
        public int TagId { get; set; }
    }
}
