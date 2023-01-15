using PhonchicK.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonchicK.Business.Abstract
{
    public interface ICapacitorService
    {
        Capacitor Add(Capacitor capacitor);
        void Update(Capacitor capacitor);
        void Delete(Capacitor capacitor);
        List<Capacitor> GetByPage(int page = 1, int itemByPage = 10);
        int GetPageCount();
        Capacitor Get(int id);
    }
}
