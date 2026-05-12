using AppLayer.AuthFilters;
using AppLayer.Models;
using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AppLayer.Controllers
{
    public class HomeController : Controller
    {
        UserService userService;
        CustomerService customerService;
        public HomeController(UserService userService, CustomerService customerService)
        {
            this.userService = userService;
            this.customerService = customerService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Registration()
        {
            return View(new RegistrationDTO());
        }

        [HttpPost]
        public IActionResult Registration(RegistrationDTO registration)
        {
            var exEmail = userService.GetByEmail(registration.Email);
            if (ModelState.IsValid && exEmail == null)
            {
                userService.Add(registration);
                customerService.Add(registration);

                return RedirectToAction("Index", "Customer");
            }

            return View(registration);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
