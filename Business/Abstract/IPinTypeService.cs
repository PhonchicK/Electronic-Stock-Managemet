using PhonchicK.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonchicK.Business.Abstract
{
    public interface IPinTypeService
    {
        PinType Add(PinType pinType);
        void Update(PinType pinType);
        void Delete(PinType pinType);
        List<PinType> GetByPage(int page = 1, int itemByPage = 10);
        PinType Get(int id);
    }
}
