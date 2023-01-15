using PhonchicK.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonchicK.Business.Abstract
{
    public interface ITransistorService
    {
        Transistor Add(Transistor transistor);
        void Update(Transistor transistor);
        void Delete(Transistor transistor);
        List<Transistor> GetByPage(int page = 1, int itemByPage = 10);
        Transistor Get(int id);
    }
}
