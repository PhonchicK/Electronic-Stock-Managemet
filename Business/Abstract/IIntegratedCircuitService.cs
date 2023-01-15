using PhonchicK.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonchicK.Business.Abstract
{
    public interface IIntegratedCircuitService
    {
        IntegratedCircuit Add(IntegratedCircuit integratedCircuit);
        void Update(IntegratedCircuit integratedCircuit);
        void Delete(IntegratedCircuit integratedCircuit);
        List<IntegratedCircuit> GetByPage(int page = 1, int itemByPage = 10);
        int GetPageCount();
        IntegratedCircuit Get(int id);
    }
}
