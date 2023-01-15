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
    public class OtherObjectManager : IOtherObjectService
    {
        IOtherObjectDal otherObjectDal;

        public OtherObjectManager(IOtherObjectDal otherObjectDal)
        {
            this.otherObjectDal = otherObjectDal;
        }

        public OtherObject Add(OtherObject otherObject)
        {
            return this.otherObjectDal.Add(otherObject);
        }

        public void Delete(OtherObject otherObject)
        {
            this.otherObjectDal.Delete(otherObject);
        }

        public OtherObject Get(int id)
        {
            return this.otherObjectDal.Get(o => o.ID == id);
        }

        public List<OtherObject> GetByCategory(int categoryId, int page = 1, int itemByPage = 10)
        {
            return this.otherObjectDal.GetPage(o => o.CategoryID == categoryId, page, itemByPage);
        }

        public List<OtherObject> GetByPage(int page = 1, int itemByPage = 10)
        {
            return this.otherObjectDal.GetPage(null, page, itemByPage);
        }

        public int GetPageCount()
        {
            return this.otherObjectDal.GetPageCount();
        }

        public void Update(OtherObject otherObject)
        {
            this.otherObjectDal.Update(otherObject);
        }
    }
}
