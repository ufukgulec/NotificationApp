using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace Notification.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationController : Controller
    {
        private readonly IHubContext<NotificationHub, INotificationClient> _context;

        public NotificationController(IHubContext<NotificationHub, INotificationClient> context)
        {
            _context = context;
        }

        [HttpGet("SendMessage")]
        public async Task<IActionResult> GetById(string message)
        {
            await _context.Clients.All.ReceiveNotification($"{message}");

            return Ok($"Mesaj {UserHandler.ConnectedIds.Count} bağlantıya iletildi.");
        }

    }
}
