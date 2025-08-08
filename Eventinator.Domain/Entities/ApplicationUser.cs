using Microsoft.AspNetCore.Identity;

namespace Eventinator.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        // Add custom properties if needed
        public string? CustomField { get; set; }
    }
}
