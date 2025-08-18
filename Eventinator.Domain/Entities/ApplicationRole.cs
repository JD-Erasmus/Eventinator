using Microsoft.AspNetCore.Identity;

namespace Eventinator.Domain.Entities
{
    public class ApplicationRole : IdentityRole
    {

        // Navigation property for users in this role
        public virtual ICollection<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();
    }
}
