using CoreViewComponent.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreViewComponent.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        private readonly ICategoryRepository repo;

        public CategoryViewComponent(ICategoryRepository _repo)
        {
            repo = _repo;
        }
        public IViewComponentResult Invoke()
        {
            return View(repo.Categories);
        }
    }
}
