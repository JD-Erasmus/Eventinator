namespace Eventinator.Application.DTOs
{
    public class EventAttendeeReadDTO : BaseAuditDTO
    {
        public int UserId { get; set; }
        public int EventId { get; set; }
    }

    public class EventAttendeeUpdateDTO : BaseAuditDTO
    {
        public int UserId { get; set; }
        public int EventId { get; set; }
    }

    public class EventAttendeeDeleteDTO : BaseDTO
    {
    }

    public class EventAttendeeCreateDTO
    {
        public int UserId { get; set; }
        public int EventId { get; set; }
    }
}
