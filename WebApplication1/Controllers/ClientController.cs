using DI.Services;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientService _IClientService;
        private readonly IPurchaseService _IPurchaseService;
        public ClientController(IClientService clientService, IPurchaseService purchaseService)
        {
            _IClientService = clientService;
            _IPurchaseService = purchaseService;
        }
        public ActionResult Index() 
        {
            var clients = _IClientService.GetClients();
            return View(clients);
        }
        public ActionResult PurchaseClient()
        {
            var purchases = _IPurchaseService.GetPurchaseClient(1);
            return View(purchases);
        }
    }
}
