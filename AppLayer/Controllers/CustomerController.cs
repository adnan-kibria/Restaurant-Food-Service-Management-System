using Microsoft.AspNetCore.Mvc;

namespace AppLayer.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
