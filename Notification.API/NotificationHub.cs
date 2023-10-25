using Microsoft.AspNetCore.SignalR;

namespace Notification.API
{
    public static class UserHandler
    {
        public static HashSet<string> ConnectedIds = new HashSet<string>();
    }

    public class NotificationHub : Hub<INotificationClient>
    {
        public override async Task OnConnectedAsync()
        {
            UserHandler.ConnectedIds.Add(Context.ConnectionId);
            await Clients.Client(Context.ConnectionId).ReceiveNotification(
                  $"Signal R ile sunucu dinleniyor.");


            await base.OnConnectedAsync();
        }
    }
}

public interface INotificationClient
{
    Task ReceiveNotification(string message);
    Task<int> GetConnectionCount();
}