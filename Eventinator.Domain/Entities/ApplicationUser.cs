using Microsoft.AspNetCore.Identity;

namespace Eventinator.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        // Navigation property for EventAttendees
        public ICollection<EventAttendee> EventAttendees { get; set; } = new List<EventAttendee>();
        // Navigation property for Subscriptions
        public ICollection<Subscription> Subscriptions { get; set; } = new List<Subscription>();
        // Navigation property for Payments
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
