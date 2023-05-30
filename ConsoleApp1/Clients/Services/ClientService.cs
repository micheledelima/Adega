using Store.Clients.Interfaces.Services;
using Store.Clients.Models;

namespace Store.Clients.Services
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
