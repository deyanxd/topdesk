using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using topdesk.Services.Contracts;
using topdesk_app.Models;

namespace topdesk_app.Controllers
{
    public class HomeController : Controller
    {
        private IComputersService service;
        public HomeController(IComputersService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            var model = service.GetAllComputers();
            return View(model);
        }

        public IActionResult Test()
        {
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
