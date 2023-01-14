using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonchicK.Entities.Concrete
{
    public class PinType : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
