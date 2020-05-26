using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreViewComponent.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly List<Category> categories = new List<Category>() {
             new Category() {CategoeryId = 1 ,CategoryName = "Telefon"},
             new Category() {CategoeryId = 2 ,CategoryName = "Tablet"},
             new Category() {CategoeryId = 3 ,CategoryName = "Bilgisayar"},
        };

        public IEnumerable<Category> Categories => categories;

        public void AddCategory(Category entity)
        {
            categories.Add(entity);
        }
    }
}
