using Core.DataAccess.EntityFramework;
using PhonchicK.DataAccess.Abstract;
using PhonchicK.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonchicK.DataAccess.Concrete.EntityFramework
{
    public class EfDatasheetDal : EfEntityRepositoryBase<Datasheet, StockContext>, IDatasheetDal { }
}
