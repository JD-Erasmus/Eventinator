using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventinator.Application.DTOs;
using Eventinator.Domain.Entities;
using Eventinator.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Eventinator.Application.Interfaces;

namespace Eventinator.Application.Implementation
{
    public class EventService : IEventService
    {
        private readonly ApplicationDbContext _db;
        public EventService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<EventReadDTO> GetByIdAsync(int id)
        {
            var evt = await _db.Events.FindAsync(id);
            if (evt == null) return null;
            return new EventReadDTO
            {
                Id = evt.Id,
                Title = evt.Title,
                Description = evt.Description,
                StartTime = evt.StartTime,
                EndTime = evt.EndTime,
                Capacity = evt.Capacity,
                OrganizerId = evt.OrganizerId,
                LocationId = evt.LocationId
            };
        }

        public async Task<IEnumerable<EventReadDTO>> GetAllAsync()
        {
            return await _db.Events.Select(evt => new EventReadDTO
            {
                Id = evt.Id,
                Title = evt.Title,
                Description = evt.Description,
                StartTime = evt.StartTime,
                EndTime = evt.EndTime,
                Capacity = evt.Capacity,
                OrganizerId = evt.OrganizerId,
                LocationId = evt.LocationId
            }).ToListAsync();
        }

        public async Task<EventReadDTO> CreateAsync(EventCreateDTO dto)
        {
            var evt = new Event
            {
                Title = dto.Title,
                Description = dto.Description,
                StartTime = dto.StartTime,
                EndTime = dto.EndTime,
                Capacity = dto.Capacity,
                OrganizerId = dto.OrganizerId,
                LocationId = dto.LocationId
            };
            _db.Events.Add(evt);
            await _db.SaveChangesAsync();
            return await GetByIdAsync(evt.Id);
        }

        public async Task<EventReadDTO> UpdateAsync(int id, EventUpdateDTO dto)
        {
            var evt = await _db.Events.FindAsync(id);
            if (evt == null) return null;
            // Set RowVersion for concurrency
            _db.Entry(evt).Property(e => e.RowVersion).OriginalValue = dto.RowVersion;
            evt.Title = dto.Title;
            evt.Description = dto.Description;
            evt.StartTime = dto.StartTime;
            evt.EndTime = dto.EndTime;
            evt.Capacity = dto.Capacity;
            evt.OrganizerId = dto.OrganizerId;
            evt.LocationId = dto.LocationId;
            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                // Handle concurrency conflict (e.g., return null or custom error)
                return null;
            }
            return await GetByIdAsync(evt.Id);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var evt = await _db.Events.FindAsync(id);
            if (evt == null) return false;
            _db.Events.Remove(evt);
            await _db.SaveChangesAsync();
            return true;
        }
    }
}
