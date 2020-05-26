using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreFirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreFirstApp.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            Category category = new Category() { Id = 1, Name = "Soğuk içecekler", Description = "Açıklama" };

            return View(category);
        }
    }
}