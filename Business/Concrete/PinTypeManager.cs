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
    public class PinTypeManager : IPinTypeService
    {
        IPinTypeDal pinTypeDal;

        public PinTypeManager(IPinTypeDal pinTypeDal)
        {
            this.pinTypeDal = pinTypeDal;
        }

        public PinType Add(PinType pinType)
        {
            return this.pinTypeDal.Add(pinType);
        }

        public void Delete(PinType pinType)
        {
            this.pinTypeDal.Delete(pinType);
        }

        public PinType Get(int id)
        {
            return this.pinTypeDal.Get(p => p.ID == id);
        }

        public List<PinType> GetByPage(int page = 1, int itemByPage = 10)
        {
            return this.pinTypeDal.GetPage(null, page, itemByPage);
        }

        public int GetPageCount()
        {
            return this.pinTypeDal.GetPageCount();
        }

        public void Update(PinType pinType)
        {
            this.pinTypeDal.Update(pinType);
        }
    }
}
