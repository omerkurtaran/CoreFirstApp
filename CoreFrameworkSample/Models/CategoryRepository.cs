using CoreFrameworkSample.Data;
using Microsoft.AspNetCore.Mvc.DataAnnotations.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreFrameworkSample.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private ApplicationDbContext db;
        public CategoryRepository(ApplicationDbContext _context)
        {
            db = _context;
        }
        public bool Add(Category category)
        {
            try
            {
                db.Categories.Add(category);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int Id)
        {
            try
            {
                Category element = db.Categories.FirstOrDefault(z => z.Id == Id);
                db.Categories.Remove(element);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public List<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public bool Update(Category category)
        {
            try
            {
                Category updateCategory = db.Categories.First(z => z.Id == category.Id);
                updateCategory.Name = category.Name;
                updateCategory.Products = category.Products;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
