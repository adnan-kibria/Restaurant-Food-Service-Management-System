using Microsoft.AspNetCore.Mvc;

namespace AppLayer.Controllers
{
    public class DeliveryManController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
