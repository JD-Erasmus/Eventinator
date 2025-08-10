using System.Collections.Generic;

namespace Eventinator.Domain.Entities
{
    public class Tag : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<EventTag> EventTags { get; set; } = new List<EventTag>();
    }
}
