using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreFrameworkSample.Models
{
    public interface ICategoryRepository
    {
        bool Add(Category category);
        bool Update(Category category);
        bool Delete(int Id);
        List<Category> GetAll();
    }
}
