using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AppLayer.AuthFilters
{
    public class Logged : Attribute, IAuthorizationFilter
    {
        private string[] roles;
        public Logged(params string[] roles)
        {
            this.roles = roles;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var email = context.HttpContext.Session.GetString("Email");
            var roleId = context.HttpContext.Session.GetInt32("RoleId");

            if(email == null || roleId == null)
            {
                var cookieEmail = context.HttpContext.Request.Cookies["Email"];
                var cookieRoleId = context.HttpContext.Request.Cookies["RoleId"];

                if(!string.IsNullOrEmpty(cookieEmail) &&  !string.IsNullOrEmpty(cookieRoleId))
                {
                    context.HttpContext.Session.SetString("Email", cookieEmail);
                    context.HttpContext.Session.SetInt32("RoleId", int.Parse(cookieRoleId));
                    email = cookieEmail;
                    roleId = int.Parse(cookieRoleId);
                }
            }

            if (email == null || roleId == null || !roles.Contains(roleId.ToString()))
            {
                context.Result = new RedirectToActionResult("Login", "Auth", null);
            }
        }
    }
}
