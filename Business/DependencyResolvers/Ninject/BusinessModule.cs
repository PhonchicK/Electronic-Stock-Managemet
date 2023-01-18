using Ninject.Modules;
using PhonchicK.Business.Abstract;
using PhonchicK.Business.Concrete;
using PhonchicK.DataAccess.Abstract;
using PhonchicK.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonchicK.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICapacitorDal>().To<EfCapacitorDal>().InSingletonScope();
            Bind<ICapacitorService>().To<CapacitorManager>().InSingletonScope();

            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();
            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();

            Bind<IDatasheetDal>().To<EfDatasheetDal>().InSingletonScope();
            Bind<IDatasheetService>().To<DatasheetManager>().InSingletonScope();

            Bind<IIntegratedCircuitDal>().To<EfIntegratedCircuitDal>().InSingletonScope();
            Bind<IIntegratedCircuitService>().To<IntegratedCircuitManager>().InSingletonScope();

            Bind<IOtherObjectDal>().To<EfOtherObjectDal>().InSingletonScope();
            Bind<IOtherObjectService>().To<OtherObjectManager>().InSingletonScope();

            Bind<IPinTypeDal>().To<EfPinTypeDal>().InSingletonScope();
            Bind<IPinTypeService>().To<PinTypeManager>().InSingletonScope();

            Bind<IResistorDal>().To<EfResistorDal>().InSingletonScope();
            Bind<IResistorService>().To<ResistorManager>().InSingletonScope();

            Bind<ITransistorDal>().To<EfTransistorDal>().InSingletonScope();
            Bind<ITransistorService>().To<TransistorManager>().InSingletonScope();
        }
    }
}
