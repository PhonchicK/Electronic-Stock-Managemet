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
    public class IntegratedCircuitManager : IIntegratedCircuitService
    {
        IIntegratedCircuitDal integratedCircuitDal;

        public IntegratedCircuitManager(IIntegratedCircuitDal ıntegratedCircuitDal)
        {
            this.integratedCircuitDal = ıntegratedCircuitDal;
        }

        public IntegratedCircuit Add(IntegratedCircuit integratedCircuit)
        {
            return this.integratedCircuitDal.Add(integratedCircuit);
        }

        public void Delete(IntegratedCircuit integratedCircuit)
        {
            this.integratedCircuitDal.Delete(integratedCircuit);
        }

        public IntegratedCircuit Get(int id)
        {
            return this.integratedCircuitDal.Get(iC => iC.ID == id);
        }

        public List<IntegratedCircuit> GetByPage(int page = 1, int itemByPage = 10)
        {
            return this.integratedCircuitDal.GetPage(null, page, itemByPage);
        }

        public int GetPageCount()
        {
            return this.integratedCircuitDal.GetPageCount();
        }

        public void Update(IntegratedCircuit integratedCircuit)
        {
            this.integratedCircuitDal.Update(integratedCircuit);
        }
    }
}
