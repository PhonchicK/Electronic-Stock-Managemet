using PhonchicK.Business.Abstract;
using PhonchicK.DataAccess.Abstract;
using PhonchicK.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonchicK.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            this.categoryDal = categoryDal;
        }

        public Category Add(Category category)
        {
            return this.categoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            this.categoryDal.Delete(category);
        }

        public Category Get(int id)
        {
            return this.categoryDal.Get(c => c.ID == id);
        }

        public List<Category> GetByPage(int page = 1, int itemByPage = 10)
        {
            return this.categoryDal.GetPage(c => c.ParentCategoryID == null, page, itemByPage);
        }

        public List<Category> GetChilderen(int parentCategoryId)
        {
            return this.categoryDal.GetAll(c => c.ParentCategoryID == parentCategoryId);
        }

        public int GetPageCount()
        {
            return this.categoryDal.GetPageCount(c => c.ParentCategoryID == null);
        }

        public void Update(Category category)
        {
            this.categoryDal.Update(category);
        }
    }
}
