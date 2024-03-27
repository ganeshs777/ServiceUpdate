using Microsoft.AspNetCore.SignalR;
using ServiceUpdate.Models.Models;

namespace ServiceUpdate.SignalR.Hubs
{
    public class ServiceUpdaterHub : Hub
    {
        public async Task SendServiceUpdateMessage(ServiceUpdate.Models.Models.ServiceUpdate serviceUpdate)
        {
            await Clients.All.SendAsync("ReceiveServiceUpdateMessage", serviceUpdate);
        }
    }
}
