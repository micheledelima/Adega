using Store.Clients.Models;

namespace Store.Clients.Interfaces.Services
{
    public interface IClientService
    {
        public bool SetClient(ClientModel clientModel);
        public bool UpdateClient(ClientModel clientModel);
    }
}
