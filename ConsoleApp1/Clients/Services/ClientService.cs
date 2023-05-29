using Loja.Clients.Interfaces.Services;
using Loja.Clients.Models;

namespace Loja.Clients.Services
{
    public class ClientService : IClientService
    {
        public bool SetClient(ClientModel clientModel)
        {
            if (clientModel != null)
            {
                return true;
            }
            return false;
        }

        public bool UpdateClient(ClientModel clientModel)
        {
            if (clientModel != null)
            {
                return true;
            }
            return false;
        }
    }
}
