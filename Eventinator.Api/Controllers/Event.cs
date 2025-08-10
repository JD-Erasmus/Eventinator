using Eventinator.Application.DTOs;
using Eventinator.Application.Implementation;
using Microsoft.AspNetCore.Mvc;

namespace Eventinator.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly EventService _eventService;
        public EventsController(EventService eventService)
        {
            _eventService = eventService;
        }

        [HttpPost("CreateEvent")]
        public async Task<IActionResult> Create([FromBody] EventCreateDTO dto)
        {
            var created = await _eventService.CreateAsync(dto);
            if (created == null)
                return BadRequest(new { error = "Event could not be created." });
            return Created($"/api/events/{created.Id}", created);
        }

        // You can add more actions for Get, Update, Delete, etc.
    }
}
