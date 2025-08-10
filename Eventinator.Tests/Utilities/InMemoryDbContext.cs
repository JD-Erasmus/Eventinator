using Eventinator.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Eventinator.Tests.Utilities
{
    public static class InMemoryDbContext
    {
        public static ApplicationDbContext Create()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            return new ApplicationDbContext(options);
        }
    }
}
