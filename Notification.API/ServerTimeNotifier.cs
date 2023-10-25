using Microsoft.AspNetCore.SignalR;

namespace Notification.API
{
    public class ServerTimeNotifier : BackgroundService
    {
        private static readonly TimeSpan Period = TimeSpan.FromSeconds(5);


        private readonly IHubContext<NotificationHub, INotificationClient> _context;


        public ServerTimeNotifier( IHubContext<NotificationHub, INotificationClient> context)
        {
            _context = context;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            using var timer = new PeriodicTimer(period: Period);

            while (!stoppingToken.IsCancellationRequested && await timer.WaitForNextTickAsync(stoppingToken))
            {
                var datetime = DateTime.Now;

                //_logger.LogInformation("Executing {Service} {Time}", nameof(ServerTimeNotifier));

                await _context.Clients.All.ReceiveNotification($"Server time = {datetime}");

            }
        }
    }
}
