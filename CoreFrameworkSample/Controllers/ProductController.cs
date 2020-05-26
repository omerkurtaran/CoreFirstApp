using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreFrameworkSample.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreFrameworkSample.Controllers
{
    public class ProductController : Controller
    {
        private ICategoryRepository categoryRepo;
        private IProductRepository productRepo;
        public ProductController(
            ICategoryRepository _categoryRepo, 
            IProductRepository _productRepo)
        {
            categoryRepo = _categoryRepo;
            productRepo = _productRepo;
        }
        public IActionResult Index()
        {
            ProductViewModel viewModel = new ProductViewModel();
            viewModel.Categories = categoryRepo.GetAll();
            viewModel.Product = new Product();
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Index(ProductViewModel p)
        {
            return View();
        }
    }
}