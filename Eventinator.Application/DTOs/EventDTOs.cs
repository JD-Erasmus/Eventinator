namespace Eventinator.Application.DTOs
{
    public class EventCreateDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public int OrganizerId { get; set; }
    }

    public class EventReadDTO : BaseAuditDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public int OrganizerId { get; set; }
    }

    public class EventUpdateDTO : BaseAuditDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public int OrganizerId { get; set; }
    }

    public class EventDeleteDTO : BaseDTO
    {
    }
}
