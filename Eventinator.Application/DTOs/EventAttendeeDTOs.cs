namespace Eventinator.Application.DTOs
{
    public class EventAttendeeReadDTO : BaseAuditDTO
    {
        public string UserId { get; set; }
        public int EventId { get; set; }
    }

    public class EventAttendeeUpdateDTO : BaseAuditDTO
    {
        public string UserId { get; set; }
        public int EventId { get; set; }
    }

    public class EventAttendeeDeleteDTO : BaseDTO { }

    public class EventAttendeeCreateDTO
    {
        public string UserId { get; set; }
        public int EventId { get; set; }
    }
}
