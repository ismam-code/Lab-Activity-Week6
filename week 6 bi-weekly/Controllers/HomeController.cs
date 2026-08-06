using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using week_6_bi_weekly.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace week_6_bi_weekly.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Week 6 Bi-Weekly Task";
            ViewBag.WelcomeMessage = "Welcome to the Week 6 ASP.NET Core MVC Application!";

            ViewBag.Topics = new List<string>
            {
                "Controllers and Action Methods",
                "Views and Razor Syntax",
                "Layouts and Data Transfer (ViewBag/ViewData)"
            };

            return View();
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
