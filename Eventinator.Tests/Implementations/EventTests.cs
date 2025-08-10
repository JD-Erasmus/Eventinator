using System;
using System.Linq;
using Xunit;
using Eventinator.Domain.Entities;
using Eventinator.Tests.Utilities;

namespace Eventinator.Tests.Implementations
{
    public class EventTests
    {
        [Fact]
        public void CanCreateEvent()
        {
            using var context = InMemoryDbContext.Create();
            var evt = new Event
            {
                Title = "Test Event",
                Description = "Test Description",
                StartTime = DateTime.UtcNow,
                EndTime = DateTime.UtcNow.AddHours(2),
                Capacity = 100,
                OrganizerId = 1,
                LocationId = 1
            };
            context.Events.Add(evt);
            context.SaveChanges();
            Assert.True(evt.Id > 0);
        }

        [Fact]
        public void CanReadEvent()
        {
            using var context = InMemoryDbContext.Create();
            var evt = new Event
            {
                Title = "Read Event",
                Description = "Read Description",
                StartTime = DateTime.UtcNow,
                EndTime = DateTime.UtcNow.AddHours(2),
                Capacity = 50,
                OrganizerId = 2,
                LocationId = 2
            };
            context.Events.Add(evt);
            context.SaveChanges();
            var found = context.Events.FirstOrDefault(e => e.Title == "Read Event");
            Assert.NotNull(found);
            Assert.Equal("Read Event", found.Title);
        }

        [Fact]
        public void CanUpdateEvent()
        {
            using var context = InMemoryDbContext.Create();
            var evt = new Event
            {
                Title = "Update Event",
                Description = "Update Description",
                StartTime = DateTime.UtcNow,
                EndTime = DateTime.UtcNow.AddHours(2),
                Capacity = 75,
                OrganizerId = 3,
                LocationId = 3
            };
            context.Events.Add(evt);
            context.SaveChanges();
            evt.Title = "Updated Event";
            context.Events.Update(evt);
            context.SaveChanges();
            var updated = context.Events.Find(evt.Id);
            Assert.Equal("Updated Event", updated.Title);
        }

        [Fact]
        public void CanDeleteEvent()
        {
            using var context = InMemoryDbContext.Create();
            var evt = new Event
            {
                Title = "Delete Event",
                Description = "Delete Description",
                StartTime = DateTime.UtcNow,
                EndTime = DateTime.UtcNow.AddHours(2),
                Capacity = 30,
                OrganizerId = 4,
                LocationId = 4
            };
            context.Events.Add(evt);
            context.SaveChanges();
            context.Events.Remove(evt);
            context.SaveChanges();
            var deleted = context.Events.Find(evt.Id);
            Assert.Null(deleted);
        }
    }
}
