using CoreFrameworkSample.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreFrameworkSample.Models
{

    public class ProductRepository : IProductRepository
    {
        private ApplicationDbContext db;
        public ProductRepository(ApplicationDbContext _context)
        {
            db = _context;
        }

        public bool Add(Product product)
        {
            try
            {
                db.Products.Add(product);
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
                Product deleteProduct = db.Products.FirstOrDefault(z => z.id == Id);
                db.Products.Remove(deleteProduct);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Product> GetAll()
        {
            return db.Products.ToList();
        }

        public bool Update(Product product)
        {
            try
            {
                Product updateProduct = db.Products.First(z => z.id == product.id);
                updateProduct.Name = product.Name;
                updateProduct.Price = product.Price;
                updateProduct.Stock = product.Stock;
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
