using DapperCleanArch.WebAPI.Utils;
using Microsoft.AspNetCore.SignalR;

namespace DapperCleanArch.WebAPI.Hubs
{
    public class DCAHub : Hub
    {
        private readonly static ConnectionMapping<string> _connections = new();

        public override Task OnConnectedAsync()
        {
            string name = Context.User!.Identity!.Name!;
            _connections.Add(name, Context.ConnectionId);
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception? exception)
        {
            string name = Context.User!.Identity!.Name!;
            _connections.Remove(name, Context.ConnectionId);
            return base.OnDisconnectedAsync(exception);
        }
    }
}
