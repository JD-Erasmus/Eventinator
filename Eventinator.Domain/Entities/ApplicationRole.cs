using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Eventinator.Domain.Entities
{
    public class ApplicationRole : IdentityRole
    {
        // Add custom properties if needed
        public string? CustomField { get; set; }

        // Navigation property for users in this role
        public virtual ICollection<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();
    }
}
