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
    public class DatasheetManager : IDatasheetService
    {
        IDatasheetDal datasheetDal;

        public DatasheetManager(IDatasheetDal datasheetDal)
        {
            this.datasheetDal = datasheetDal;
        }

        public Datasheet Add(Datasheet datasheet)
        {
            return this.datasheetDal.Add(datasheet);
        }

        public void Delete(Datasheet datasheet)
        {
            this.datasheetDal.Delete(datasheet);
        }

        public Datasheet Get(int id)
        {
            return this.datasheetDal.Get(d => d.ID == id);
        }

        public List<Datasheet> GetByPage(int page = 1, int itemByPage = 10)
        {
            return this.datasheetDal.GetPage(null, page, itemByPage);
        }

        public int GetPageCount()
        {
            return this.datasheetDal.GetPageCount();
        }

        public void Update(Datasheet datasheet)
        {
            this.Update(datasheet);
        }
    }
}
