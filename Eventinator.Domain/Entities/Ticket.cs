using Eventinator.Domain.Enums;
using System;

namespace Eventinator.Domain.Entities
{
    public class Ticket : BaseEntity
    {
        public int EventId { get; set; }
        public Event Event { get; set; } = null!;
        public string UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;
        public decimal Price { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string? SeatNumber { get; set; }
        public TicketType Type { get; set; }
        // Add other properties as needed
    }
}
