using System.Collections.Generic;
using System.Threading.Tasks;
using Eventinator.Application.DTOs;

namespace Eventinator.Application.Interfaces
{
    public interface IEventService
    {
        Task<EventReadDTO> GetByIdAsync(int id);
        Task<IEnumerable<EventReadDTO>> GetAllAsync();
        Task<EventReadDTO> CreateAsync(EventCreateDTO dto);
        Task<EventReadDTO> UpdateAsync(int id, EventUpdateDTO dto);
        Task<bool> DeleteAsync(int id);
    }
}
