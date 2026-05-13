using AppLayer.AuthFilters;
using Microsoft.AspNetCore.Mvc;

namespace AppLayer.Controllers
{
    public class AdminController : Controller
    {
        [Logged("1")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
