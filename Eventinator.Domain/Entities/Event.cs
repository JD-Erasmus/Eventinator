using System;

namespace Eventinator.Domain.Entities
{
    public class Event : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public int OrganizerId { get; set; }
    }
}
