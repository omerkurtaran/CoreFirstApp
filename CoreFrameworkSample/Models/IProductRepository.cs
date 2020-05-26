using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreFrameworkSample.Models
{
    public interface IProductRepository
    {
        bool Add(Product product);
        bool Update(Product product);
        bool Delete(int Id);
        List<Product> GetAll();
    }
}
