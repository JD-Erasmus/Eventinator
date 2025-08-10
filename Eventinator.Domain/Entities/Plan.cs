using System.Collections.Generic;

namespace Eventinator.Domain.Entities
{
    public class Plan : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ICollection<Subscription> Subscriptions { get; set; } = new List<Subscription>();
    }
}
