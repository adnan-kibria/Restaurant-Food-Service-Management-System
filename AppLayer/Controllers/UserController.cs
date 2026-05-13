using AppLayer.AuthFilters;
using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace AppLayer.Controllers
{
    public class UserController : Controller
    {
        RoleService roleService;
        UserService userService;
        ChefService chefService;
        DeliveryManService deliveryManService;
        ManagerService managerService;
        WaiterService waiterService;
        public UserController(RoleService roleService, UserService userService, ChefService chefService,
            DeliveryManService deliveryManService, ManagerService managerService, WaiterService waiterService)
        {
            this.roleService = roleService;
            this.userService = userService;
            this.chefService = chefService;
            this.deliveryManService = deliveryManService;
            this.managerService = managerService;
            this.waiterService = waiterService;
        }

        [Logged("1")]
        [HttpGet]
        public IActionResult Registration()
        {
            var data = roleService.Get();
            var specificRoles = data
                .Where(r => r.Name == "Manager" || r.Name == "DeliveryMan" || r.Name == "Chef" || r.Name == "Waiter")
                .Select(r => new { r.Id, r.Name })
                .ToList();
            ViewBag.Roles = specificRoles;
            return View(new RegistrationDTO());
        }

        [Logged("1")]
        [HttpPost]
        public IActionResult Registration(RegistrationDTO registration)
        {
            var exEmail = userService.GetByEmail(registration.Email);
            if (ModelState.IsValid && exEmail == null)
            {
                userService.Add(registration);
                switch (registration.RoleId)
                {
                    case 3:
                        managerService.Add(registration);
                        return RedirectToAction("Login", "Auth");
                    case 5:
                        deliveryManService.Add(registration);
                        return RedirectToAction("Login", "Auth");
                    case 6:
                        chefService.Add(registration);
                        return RedirectToAction("Login", "Auth");
                    case 7:
                        waiterService.Add(registration);
                        return RedirectToAction("Login", "Auth");
                    default:
                        return View(registration);
                }
            }

            ViewBag.Roles = roleService.Get();
            return View(registration);
        }
    }
}
