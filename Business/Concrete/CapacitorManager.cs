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
    public class CapacitorManager : ICapacitorService
    {
        ICapacitorDal capacitorDal;

        public CapacitorManager(ICapacitorDal capacitorDal)
        {
            this.capacitorDal = capacitorDal;
        }

        public Capacitor Add(Capacitor capacitor)
        {
            return this.capacitorDal.Add(capacitor);
        }

        public void Delete(Capacitor capacitor)
        {
            this.capacitorDal.Delete(capacitor);
        }

        public Capacitor Get(int id)
        {
            return this.capacitorDal.Get(c => c.ID == id);
        }

        public List<Capacitor> GetByPage(int page = 1, int itemByPage = 10)
        {
            return this.capacitorDal.GetPage(null, page, itemByPage);
        }

        public int GetPageCount()
        {
            return this.capacitorDal.GetPageCount();
        }

        public void Update(Capacitor capacitor)
        {
            this.capacitorDal.Update(capacitor);
        }
    }
}
