using Microsoft.AspNetCore.Mvc;

namespace AppLayer.Controllers
{
    public class ChefController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
