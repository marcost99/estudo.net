using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IPurchaseService
    {
        List<Purchase> GetPurchaseClient(int clientId);
    }
}
