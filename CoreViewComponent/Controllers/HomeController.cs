using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreViewComponent.Models;

namespace CoreViewComponent.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository repo;
        public HomeController(IProductRepository _repo)
        {
            repo = _repo;
        }

        public IActionResult Index()
        {
            return View(repo.Products);
        }

    }
}
