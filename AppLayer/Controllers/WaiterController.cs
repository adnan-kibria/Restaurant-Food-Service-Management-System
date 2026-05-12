using Microsoft.AspNetCore.Mvc;

namespace AppLayer.Controllers
{
    public class WaiterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
