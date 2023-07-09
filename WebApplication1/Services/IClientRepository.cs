using DI.Models;

namespace DI.Services
{
    public interface IClientRepository
    {
        public List<Client> GetClients();
    }
}
