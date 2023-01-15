using PhonchicK.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonchicK.Business.Abstract
{
    public interface ICategoryService
    {
        Category Add(Category category);
        void Update(Category category);
        void Delete(Category category);
        List<Category> GetByPage(int page = 1, int itemByPage = 10);
        int GetPageCount();
        List<Category> GetChilderen(int parentCategoryId);
        Category Get(int id);
    }
}
