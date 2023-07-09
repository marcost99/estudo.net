using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class PurchaseService : IPurchaseService
    {
        private readonly IPurchaseRepository _purchaseRepository;
        public PurchaseService(IPurchaseRepository purchaseRepository)
        {
            _purchaseRepository = purchaseRepository;
        }
        public List<Purchase> GetPurchaseClient(int clientId) 
        {
            return _purchaseRepository.GetPurchaseClient(clientId);
        }
    }
}
