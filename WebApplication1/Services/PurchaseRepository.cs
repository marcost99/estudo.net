using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class PurchaseRepository : IPurchaseRepository
    {
        public List<Purchase> GetPurchaseClient(int clientId)
        {
            var purchases = new List<Purchase>();
            purchases.Add(new Purchase
            {
                purchaseId = 1,
                clientId = 1
            });
            purchases.Add(new Purchase
            {
                purchaseId = 2,
                clientId = 1
            });
            return purchases;
        }
    }
}
