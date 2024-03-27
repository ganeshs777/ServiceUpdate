using Microsoft.AspNetCore.SignalR.Client;
using ServiceUpdate.Models.Models;

namespace ServiceUpdateService
{
    public class SignalRServiceUpdaterService
    {
        private readonly HubConnection _connection;

        public event Action<ServiceUpdate.Models.Models.ServiceUpdate> UpdateServiceMessageReceived;

        public SignalRServiceUpdaterService(HubConnection connection)
        {
            _connection = connection;
            _connection.On<ServiceUpdate.Models.Models.ServiceUpdate>("ReceiveServiceUpdateMessage", (serviceUpdate) => UpdateServiceMessageReceived?.Invoke(serviceUpdate));
        }

        public async Task Connect()
        {
            await _connection.StartAsync();
        }

        public async Task SendServiceUpdateMessage(ServiceUpdate.Models.Models.ServiceUpdate serviceUpdate)
        {
            await _connection.SendAsync("SendServiceUpdateMessage", serviceUpdate);
        }
    }
}
