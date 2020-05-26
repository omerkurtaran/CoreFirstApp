using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TagHelpers.Models;

namespace TagHelpers.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View(ProductRepository.Products);
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Product product)
        {
            if (ModelState.IsValid)
            {
                ProductRepository.AddProduct(product);
                return RedirectToAction("Index");
            }
            else
            {
                return View(product);
            }
        }

        public IActionResult Edit(int Id)
        {
            Product product = ProductRepository.Products.FirstOrDefault(z => z.Id == Id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            ProductRepository.EditProduct(product);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int Id)
        {
            ProductRepository.DeleteProduct(Id);
            return RedirectToAction("Index");
        }
    }
}