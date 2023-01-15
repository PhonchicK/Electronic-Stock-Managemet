using PhonchicK.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonchicK.Business.Abstract
{
    public interface IResistorService
    {
        Resistor Add(Resistor resistor);
        void Update(Resistor resistor);
        void Delete(Resistor resistor);
        List<Resistor> GetByPage(int page = 1, int itemByPage = 10);
        Resistor Get(int id);
    }
}
