using PhonchicK.Business.Abstract;
using PhonchicK.Business.DependencyResolvers.Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonchicK.ConsoleUI.Helpers
{
    internal static class ServiceHelper
    {
        internal static ICapacitorService CapacitorService()
        {
            return InstanceFactory.GetInstance<ICapacitorService>();
        }
        internal static ICategoryService CategoryService()
        {
            return InstanceFactory.GetInstance<ICategoryService>();
        }
        internal static IDatasheetService DatasheetService()
        {
            return InstanceFactory.GetInstance<IDatasheetService>();
        }
        internal static IIntegratedCircuitService IntegratedCircuitService()
        {
            return InstanceFactory.GetInstance<IIntegratedCircuitService>();
        }
        internal static IOtherObjectService OtherObjectService()
        {
            return InstanceFactory.GetInstance<IOtherObjectService>();
        }
        internal static IPinTypeService PinTypeService()
        {
            return InstanceFactory.GetInstance<IPinTypeService>();
        }
        internal static IResistorService ResistorService()
        {
            return InstanceFactory.GetInstance<IResistorService>();
        }
        internal static ITransistorService TransistorService()
        {
            return InstanceFactory.GetInstance<ITransistorService>();
        }
    }
}
