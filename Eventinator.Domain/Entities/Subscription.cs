using System;
using System.Collections.Generic;

namespace Eventinator.Domain.Entities
{
    public class Subscription : BaseEntity
    {
        public int UserId { get; set; }
        public int PlanId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public Plan Plan { get; set; } = null!;
    }
}
