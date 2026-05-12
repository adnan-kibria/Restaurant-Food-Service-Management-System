using Microsoft.AspNetCore.Mvc;

namespace AppLayer.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
