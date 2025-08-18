using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eventinator.Domain.Entities
{
    public class Event : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Capacity { get; set; }
        // Organizer (AspNetUsers string key)
        public string OrganizerId { get; set; }
        public ApplicationUser Organizer { get; set; }
        // Location
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public ICollection<EventAttendee> Attendees { get; set; } = new List<EventAttendee>();
        public ICollection<EventTag> EventTags { get; set; } = new List<EventTag>();
    }
}
