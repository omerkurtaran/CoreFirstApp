using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreViewComponent.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new List<Product>() {
            new Product {ProductId = 1,ProductName = "Samsung note 3",CategoryId =1,IsApproved =true,Price=100},
            new Product {ProductId = 2,ProductName = "Apple 2",CategoryId =2,IsApproved =true,Price=300},
            new Product {ProductId = 3,ProductName = "Hp Notebook",CategoryId =3,IsApproved =true,Price=200},

        };
        public IEnumerable<Product> Products => _products;

        public void AddProduct(Product entitiy)
        {
            _products.Add(entitiy);
        }
    }

}
