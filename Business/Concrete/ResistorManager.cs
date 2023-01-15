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
    public class ResistorManager : IResistorService
    {
        IResistorDal resistorDal;

        public ResistorManager(IResistorDal resistorDal)
        {
            this.resistorDal = resistorDal;
        }

        public Resistor Add(Resistor resistor)
        {
            return this.resistorDal.Add(resistor);
        }

        public void Delete(Resistor resistor)
        {
            this.resistorDal.Delete(resistor);
        }

        public Resistor Get(int id)
        {
            return this.resistorDal.Get(r => r.ID == id);
        }

        public List<Resistor> GetByPage(int page = 1, int itemByPage = 10)
        {
            return this.resistorDal.GetPage(null, page, itemByPage);
        }

        public int GetPageCount()
        {
            return this.resistorDal.GetPageCount();
        }

        public void Update(Resistor resistor)
        {
            this.resistorDal.Update(resistor);
        }
    }
}
