using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using School.Models;

namespace School.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Role = "Guest";
            ViewBag.login = true;
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Role = "Guest";
            ViewBag.login = true;
            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Role = "Guest";
            ViewBag.login = true;
            return View();
        }

        public IActionResult Admin()
        {
            ViewBag.Role = "Admin";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
