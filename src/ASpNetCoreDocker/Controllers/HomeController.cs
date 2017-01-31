using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASpNetCoreDocker.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Описание приложения.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Контактные данные.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
