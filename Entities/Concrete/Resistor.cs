using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonchicK.Entities.Concrete
{
    public class Resistor : IEntity
    {
        public int ID { get; set; }
        public float Resistance { get; set; }
        public int Tolerance { get; set; }
        public int BandCount { get; set; }
        public float Power { get; set; }
        public int PinTypeID { get; set; }

        public virtual PinType PinType { get; set; }
    }
}
