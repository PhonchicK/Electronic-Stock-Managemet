using PhonchicK.Business.Abstract;
using PhonchicK.Business.Concrete;
using PhonchicK.DataAccess.Concrete.EntityFramework;
using PhonchicK.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonchicK.ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IResistorService resistorService = new ResistorManager(new EfResistorDal());
            IPinTypeService pinTypeService = new PinTypeManager(new EfPinTypeDal());

            pinTypeService.Add(new PinType()
            {
                 Name = "0.6w Direnç"
            });
            Console.ReadKey();
        }
    }
}
