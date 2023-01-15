using PhonchicK.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonchicK.Business.Abstract
{
    public interface IDatasheetService
    {
        Datasheet Add(Datasheet datasheet);
        void Update(Datasheet datasheet);
        void Delete(Datasheet datasheet);
        List<Datasheet> GetByPage(int page = 1, int itemByPage = 10);
        int GetPageCount();
        Datasheet Get(int id);
    }
}
