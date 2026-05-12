using AppLayer.AuthFilters;
using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace AppLayer.Controllers
{
    public class AuthController : Controller
    {
        AuthService authService;
        RoleService roleService;
        public AuthController(AuthService authService, RoleService roleService)
        {
            this.authService = authService;
            this.roleService = roleService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(new UserDTO());
        }

        [HttpPost]
        public IActionResult Login(LoginDTO user)
        {
            var data = authService.Get(user);
            if(ModelState.IsValid)
            {
                if (data != null)
                {
                    HttpContext.Session.SetString("Email", data.Email);
                    HttpContext.Session.SetInt32("RoleId", data.RoleId);

                    var CookieOptions = new CookieOptions
                    {
                        Expires = DateTime.Now.AddDays(7),
                        HttpOnly = true,
                        Secure = true,
                    };

                    Response.Cookies.Append("Email", data.Email, CookieOptions);
                    Response.Cookies.Append("RoleId", data.RoleId.ToString(), CookieOptions);

                    switch (data.RoleId)
                    {
                        case 1:
                            return RedirectToAction("Index", "Admin");
                        case 2:
                            return RedirectToAction("Index", "Customer");
                        case 3:
                            return RedirectToAction("Index", "Manager");
                        case 5:
                            return RedirectToAction("Index", "DeliveryMan");
                        case 6:
                            return RedirectToAction("Index", "Chef");
                        case 7:
                            return RedirectToAction("Index", "Waiter");
                        default:
                            return RedirectToAction("Login", "Auth");
                    }
                }
            }

            TempData["errormsg"] = "Invalid email or password";
            return View(user);
        }

        [Logged("1", "2", "3", "5", "6", "7")]
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Email");
            HttpContext.Session.Remove("RoleId");
            Response.Cookies.Delete("Email");
            Response.Cookies.Delete("RoleId");

            return RedirectToAction("Login", "Auth");
        }
    }
}
