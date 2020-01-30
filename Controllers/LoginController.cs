using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace School.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            ViewBag.Role = "Guest";
            return View();
        }
        public IActionResult Validate()
        {
            if (Request.Form["username"] == "Admin" && Request.Form["password"] == "Admin")
            {
                return RedirectToAction("admin", "home");
            }
            else
                return RedirectToAction("login", "login");
        }
    }
}