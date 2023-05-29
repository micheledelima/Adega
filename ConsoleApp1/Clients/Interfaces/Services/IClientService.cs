using Loja.Clients.Models;

namespace Loja.Clients.Interfaces.Services
{
    public interface IClientService
    {
        public bool SetClient(ClientModel clientModel);
        public bool UpdateClient(ClientModel clientModel);
    }
}
