using Adega.Clients.Interfaces.Services;
using Adega.Clients.Models;

namespace Adega.Clients.Services
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
