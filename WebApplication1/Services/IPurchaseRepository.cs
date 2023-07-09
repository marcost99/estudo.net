using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IPurchaseRepository
    {
        List<Purchase> GetPurchaseClient(int clientId);
    }
}
