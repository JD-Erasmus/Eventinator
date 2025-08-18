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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventReadDTO>>> GetAll()
        {
            var list = await _eventService.GetAllAsync();
            return Ok(list);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<EventReadDTO>> GetById(int id)
        {
            var evt = await _eventService.GetByIdAsync(id);
            if (evt == null) return NotFound();
            return Ok(evt);
        }

        [HttpPost("CreateEvent")]
        public async Task<IActionResult> Create([FromBody] EventCreateDTO dto)
        {
            var created = await _eventService.CreateAsync(dto);
            if (created == null)
                return BadRequest(new { error = "Event could not be created." });
            return Created($"/api/events/{created.Id}", created);
        }

        // More actions (PUT, DELETE) can be added here.
    }
}
