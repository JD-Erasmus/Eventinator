using Microsoft.AspNetCore.Identity;

namespace Eventinator.Domain.Entities
{
    public class ApplicationRole : IdentityRole
    {
        // Add custom properties if needed
        public string? CustomField { get; set; }
    }
}
