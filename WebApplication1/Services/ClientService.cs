using DI.Models;

namespace DI.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _IClientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _IClientRepository = clientRepository;
        }

        public List<Client> GetClients()
        {
            return _IClientRepository.GetClients();
        }
    }
}
