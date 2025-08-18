using Eventinator.Application.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Eventinator.Controllers
{
    public class EventsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<EventsController> _logger;
        public EventsController(IHttpClientFactory httpClientFactory, ILogger<EventsController> logger)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
        }

        private HttpClient CreateClient() => _httpClientFactory.CreateClient("EventsApi");

        // GET: /Events
        public async Task<IActionResult> Index()
        {
            var client = CreateClient();
            IEnumerable<EventReadDTO>? events = Array.Empty<EventReadDTO>();
            try
            {
                events = await client.GetFromJsonAsync<IEnumerable<EventReadDTO>>("/events");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching events from API");
                TempData["Error"] = "Unable to load events.";
            }
            return View(events);
        }

        // GET: /Events/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var client = CreateClient();
            EventReadDTO? evt = null;
            try
            {
                evt = await client.GetFromJsonAsync<EventReadDTO>($"/events/{id}");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching event {EventId}", id);
            }
            if (evt == null) return NotFound();
            return View(evt);
        }

        // GET: /Events/Create
        public IActionResult Create()
        {
            return View(new EventCreateDTO());
        }

        // POST: /Events/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EventCreateDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return View(dto);
            }
            var client = CreateClient();
            try
            {
                // API route is /api/Events/CreateEvent -> relative path '/events/CreateEvent'
                var response = await client.PostAsJsonAsync("/events/CreateEvent", dto);
                if (response.IsSuccessStatusCode)
                {
                    var created = await response.Content.ReadFromJsonAsync<EventReadDTO>();
                    if (created != null)
                        return RedirectToAction(nameof(Details), new { id = created.Id });
                }
                else
                {
                    var body = await response.Content.ReadAsStringAsync();
                    _logger.LogWarning("API returned non-success status {Status}: {Body}", response.StatusCode, body);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating event via API");
            }
            ModelState.AddModelError(string.Empty, "Unable to create event.");
            return View(dto);
        }

        // (Update/Delete could also call API endpoints once implemented)
    }
}
