using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidationSample.Models;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationSample.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Employee emp)
        {
            if (!ModelState.IsValid)
            {
                return View(emp);
            }
            return View();
        }
    }
}