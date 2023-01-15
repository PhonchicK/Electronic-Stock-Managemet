using PhonchicK.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonchicK.Business.Abstract
{
    public interface IOtherObjectService
    {
        OtherObject Add(OtherObject otherObject);
        void Update(OtherObject otherObject);
        void Delete(OtherObject otherObject);
        List<OtherObject> GetByPage(int page = 1, int itemByPage = 10);
        int GetPageCount();
        List<OtherObject> GetByCategory(int categoryId, int page = 1, int itemByPage = 10);
        OtherObject Get(int id);
    }
}
