using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using topdesk.Services.Contracts;

namespace topdesk_app.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryService service;

        public CategoryController(ICategoryService service)
        {   
            this.service = service;
        }

        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(string name)
        {
            this.service.CreateCategory(name);
            return this.RedirectToAction("Index", "Home");
        }
    }
}
