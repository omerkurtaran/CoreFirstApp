using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagHelpers.Models
{
    public static class ProductRepository
    {
        private static List<Product> _products = new List<Product>();

        public static List<Product> Products
        {
            get { return _products; }
        }
        static int id = 1;
        public static void AddProduct(Product product)
        {
            product.Id = id;
            _products.Add(product);
            id++;
        }

        public static void EditProduct(Product product)
        {
            Product updateProd = _products.FirstOrDefault(z => z.Id == product.Id);
            updateProd.Name = product.Name;
            updateProd.Price  = product.Price;
            updateProd.Stock = product.Stock;
        }

        public static void DeleteProduct(int Id)
        {
            Product deleteProd = _products.FirstOrDefault(z => z.Id ==Id);
            _products.Remove(deleteProd);
        }

    }
}
