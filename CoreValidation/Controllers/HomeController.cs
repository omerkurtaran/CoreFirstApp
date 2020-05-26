using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreValidation.Models;

namespace CoreValidation.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View(new Register() { BirthDate = DateTime.Now });
        }

        [HttpPost]
        public IActionResult Register(Register model)
        {
            //if (string.IsNullOrEmpty(model.UserName))
            //{
            //    ModelState.AddModelError(nameof(model.UserName), "Zorunlu bir Alan");
            //}
            //if (string.IsNullOrEmpty(model.Mail) || !model.Mail.Contains("@"))
            //{
            //    ModelState.AddModelError(nameof(model.Mail), "Email düzgün girilmedi");
            //}
            //if (string.IsNullOrEmpty(model.Password) || model.Password.Length < 6)
            //{
            //    ModelState.AddModelError(nameof(model.Password), "En az 6 karekter olmalı");
            //}
            //if (!model.TermsAccepted)
            //{
            //    ModelState.AddModelError(nameof(model.TermsAccepted), "Koşulları Kabul etmelisiniz");
            //}
            if (ModelState.IsValid)
            {
                return View("Complated", model);
            }
            else
            {
                return View("Index", model);
            }
        }

    }
}
