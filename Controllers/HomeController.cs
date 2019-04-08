using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace RolesApp.Controllers
{
    public class HomeController : Controller
    { 
        [Authorize(Roles = "admin, user")]
        public IActionResult Index()
        {
            string role = User.FindFirst(x => x.Type == ClaimsIdentity.DefaultRoleClaimType).Value;
            if (role == "admin")
                return View("../Meeting/AddMeeting");
            else
                return RedirectToAction("../Meeting/GetAllMeeting");
        }
        [Authorize(Roles = "admin")]
        public IActionResult AddMeeting()
        {
            return View();
        }
    }
}