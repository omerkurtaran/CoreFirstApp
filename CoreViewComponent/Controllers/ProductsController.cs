using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreViewComponent.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreViewComponent.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductRepository repo;
        public ProductsController(IProductRepository _repo)
        {
            repo = _repo;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}