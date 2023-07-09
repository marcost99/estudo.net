using DI.Models;
using WebApplication1.Models;

namespace DI.Services
{
    public class ClientRepository : IClientRepository
    {
        public List<Client> GetClients()
        {
            var clients = new List<Client>();
            clients.Add(new Client
            {
                id = 1,
                name = "Toro"
            });
            clients.Add(new Client
            {
                id = 2,
                name = "BTG"
            });
            return clients;
        }
    }
}
