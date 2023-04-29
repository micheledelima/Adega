using Adega.Clients.Models;

namespace Adega.Clients.Interfaces.Services
{
    public interface IClientService
    {
        public bool SetClient(ClientModel clientModel);
        public bool UpdateClient(ClientModel clientModel);
    }
}
