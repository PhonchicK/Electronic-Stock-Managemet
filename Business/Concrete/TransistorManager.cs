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
    public class TransistorManager : ITransistorService
    {
        ITransistorDal transistorDal;

        public TransistorManager(ITransistorDal transistorDal)
        {
            this.transistorDal = transistorDal;
        }

        public Transistor Add(Transistor transistor)
        {
            return this.transistorDal.Add(transistor);
        }

        public void Delete(Transistor transistor)
        {
            this.transistorDal.Delete(transistor);
        }

        public Transistor Get(int id)
        {
            return this.transistorDal.Get(t => t.ID == id);
        }

        public List<Transistor> GetByPage(int page = 1, int itemByPage = 10)
        {
            return this.transistorDal.GetPage(null, page, itemByPage);
        }

        public int GetPageCount()
        {
            return this.transistorDal.GetPageCount();
        }

        public void Update(Transistor transistor)
        {
            this.transistorDal.Update(transistor);
        }
    }
}
