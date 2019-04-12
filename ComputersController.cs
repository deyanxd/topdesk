using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using topdesk.Services.Contracts;

namespace topdesk_app.Controllers
{
    public class ComputersController : Controller
    {
        private IComputersService service;
        public ComputersController(IComputersService service)
        {
            this.service = service;
        }
        public IActionResult Create()
        {
            {
                return this.View();
            }
        }
        [HttpPost]
        public IActionResult Create(string name, string description,
            string powersupply, string motherboard, string cpu,
            int ram, string harddisk, string videocard, string category)
        {
            this.service.CreateComputer(name, description, powersupply, motherboard, cpu, ram, harddisk, videocard
                , category);
            return this.RedirectToAction("Index", "Home");
        }
    }
}
